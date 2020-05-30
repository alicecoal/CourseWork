using CryptApplication.MessageBoxes;
using CryptApplication.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptApplication.Cryptos;
using CustomProgressBar = CryptApplication.Utils.CustomProgressBar;
using CryptApplication.Exceptions;
using System.IO;
using CryptApplication.Keys;

namespace CryptApplication
{
    public partial class Crypt : Form
    {
        private readonly string[] levels = {"easy", "medium", "hard" };
        private Crypto[] cryptos = { new EasyCrypto(), new MediumCrypto()};
        


        public Crypt()
        {
            InitializeComponent();
            CustomProgressBar.setProgress(progressBar);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                pathToCrypted.Text = folderName;
            }
        }

        private void chooseFileCrypted_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string folderName = folderBrowserDialog1.SelectedPath;
                pathToCrypted.Text = folderName;
            }
        }

        private void chooseFileKey_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog2.ShowDialog();
            if(result == DialogResult.OK)
            {
                string fileName = openFileDialog2.FileName;
                keyLabel.Text = fileName;
            }
        }

        private void genKey_Click(object sender, EventArgs e)
        {
            int index = chooseLevel.SelectedIndex;
            if (index < 0 || index >= levels.Length)
            {
                new ErrorBox();
                return;
            }

            DialogResult result = folderBrowserDialog2.ShowDialog();
            if(result == DialogResult.OK)
            {
                string fileName = folderBrowserDialog2.SelectedPath;
                fileName = new KeyGen(fileName, levels[chooseLevel.SelectedIndex]).getFileName();

                keyLabel.Text = fileName;
            }
            folderBrowserDialog2.Reset();
        }


        private void start_Click(object sender, EventArgs e)
        {
            if (!Validator.ValidateFileToCrypt(pathToSrc.Text)
                || !Validator.ValidateDirectoryToCrypt(pathToCrypted.Text)
                || !Validator.ValidateKey(keyLabel.Text))
            {
                Console.WriteLine("Error while validating files");
                return;
            }

            if(chooseLevel.SelectedIndex < 0 || chooseLevel.SelectedIndex >= levels.Length)
            {
                Console.WriteLine("Bad index of chooseLevel");
                return;
            }

            string level = levels[chooseLevel.SelectedIndex].ToLower();
            FileInfo input = new FileInfo(pathToSrc.Text);
            FileInfo output = new FileInfo(pathToCrypted.Text + "\\" + input.Name);
            FileInfo key = new FileInfo(keyLabel.Text);

            if(level == "hard")
            {


                if (rEncrypt.Checked)
                {
                    new HardKey(input, key);
                    HardCrypto h = new HardCrypto();
                    h.SetKey(key);
                    h.Encrypt(input, output);
                    new SuccessBox("Шифрование файла прошло успешно");
                }

                if (rDecrypt.Checked)
                {
                    HardCrypto h = new HardCrypto();
                    h.SetKey(key);
                    h.Decrypt(input, output);
                    new SuccessBox("Дешифровка файла прошла успешно");
                }
                return;
            }

            foreach(Crypto crypto in cryptos)
            {
                if(crypto.GetCryptoType().ToLower() == level)
                {
                    if (rEncrypt.Checked)
                    {
                        crypto.SetKey(key);
                        crypto.Encrypt(input, output);
                        new SuccessBox("Шифрование файла прошло успешно");
                    }

                    if (rDecrypt.Checked)
                    {
                        crypto.SetKey(key);
                        crypto.Decrypt(input, output);
                        new SuccessBox("Дешифровка файла прошла успешно");
                    }
                    break;
                }
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void chooseLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rDecrypt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rEncrypt_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
