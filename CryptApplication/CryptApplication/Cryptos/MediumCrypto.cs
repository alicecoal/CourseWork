using CryptApplication.Keys;
using CryptApplication.Keys.Contents;
using CryptApplication.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Cryptos
{
    class MediumCrypto : Crypto
    {
        private readonly string CryptoType = "Medium";
        private MediumKey Key = null;

        public override void Decrypt(FileInfo input, FileInfo output)
        {
            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();

            int[] code = Key.Code();
            byte[] bytes = new byte[code.Length];

            long i = 0;
            int mx = 0;
            while (i < inputStream.Length)
            {
                mx = code.Length;
                if (inputStream.Length - i < mx) mx = (int)(inputStream.Length - i);
                inputStream.Read(bytes, 0, mx);
                for (int j = 0; j < mx; j++)
                {
                    bytes[j] = (byte)ChangeByte(bytes[j], -code[j]);
                    i++;
                    CustomProgressBar.update((int)((i) * 100 / inputStream.Length));
                }
                outputStream.Write(bytes, 0, mx);
            }

            inputStream.Close();
            outputStream.Close();
        }

        public override void Encrypt(FileInfo input, FileInfo output)
        {
            if(Key == null)
            {
                Console.WriteLine("Medium key is null!");
                return;
            }

            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();

            int[] code = Key.Code();
            byte[] bytes = new byte[code.Length];

            long i = 0;
            int mx = 0;
            while(i < inputStream.Length)
            {
                mx = code.Length;
                if (inputStream.Length - i < mx) mx = (int)(inputStream.Length - i);
                inputStream.Read(bytes, 0, mx);
                for(int j = 0; j < mx; j++)
                {
                    bytes[j] = (byte)ChangeByte(bytes[j], code[j]);
                    i++;
                    CustomProgressBar.update((int)((i) * 100 / inputStream.Length));
                }
                outputStream.Write(bytes, 0, mx);
            }

            inputStream.Close();
            outputStream.Close();
        }

        private int ChangeByte(int b, int value)
        {
            return (b + value + 256) % 256;
        }

        public long min(long a, long b)
        {
            return a < b ? a : b;
        }

        public int min(int a,int b)
        {
            return a < b ? a : b;
        }

        public override string GetCryptoType()
        {
            return CryptoType;
        }

        public override void SetKey(FileInfo file)
        {
            Key = new MediumKey(file);
        }
    }
}
