using CryptApplication.Exceptions;
using CryptApplication.Keys;
using CryptApplication.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptApplication.Cryptos
{
    class EasyCrypto : Crypto
    {
        delegate int Operation(int Byte, int sign);

        private EasyKey Key = null;
        public string CryptoType = "Easy";

        public EasyCrypto()
        {

        }

        public override void Decrypt(FileInfo input, FileInfo output)
        {
            if(Key == null)
            {
                throw new CryptException("Key File not founded!");
            }

            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();

            Operation change = ChangeByte;


            for (long i = 0; i < inputStream.Length; i++)
            {
                int Byte = inputStream.ReadByte();
                Byte = change(Byte, -1);
                outputStream.WriteByte((byte)Byte);
                CustomProgressBar.update((int)((i + 1) * 100 / inputStream.Length));

            }

            inputStream.Close();
            outputStream.Close();


        }

        public override void Encrypt(FileInfo input, FileInfo output)
        {
            if (Key == null)
            {
                throw new CryptException("Key File not founded!");
            }

            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();
            
            for(long i = 0; i < inputStream.Length; i++)
            {
                int Byte = inputStream.ReadByte();
                Byte = ChangeByte(Byte, 1);
                outputStream.WriteByte((byte)Byte);
                CustomProgressBar.update((int)((i+1) * 100 / inputStream.Length));
                
            }

            inputStream.Close();
            outputStream.Close();
            
        }

        private int ChangeByte(int Byte, int sign)
        {
            return (Byte + sign * Key.Code + 256) % 256;
        }

        public override string GetCryptoType()
        {
            return CryptoType;
        }

        public override void SetKey(FileInfo file)
        {
            Key = new EasyKey(file);
        }
    }
}
