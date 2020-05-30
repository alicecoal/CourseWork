using CryptApplication.Keys;
using CryptApplication.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Cryptos
{
    class HardCrypto : Crypto
    {
        private readonly string ContentType = "Hard";
        private HardKey key = null;

        public override void Decrypt(FileInfo input, FileInfo output)
        {
            if (key == null)
            {
                Console.WriteLine("Hard key is null");
                return;
            }

            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();

            int j = 0;
            
            long ks = 0;
            //todo переписать весь блок под чтение по байтам в одном цикле
            int bd = 0;
            for(long i = 0; i < inputStream.Length; i++)
            {
                //if(j < key.MaxBadBytes) bd = key.getBadByte(j);
                CustomProgressBar.update((int)(i * 100 / inputStream.Length));
                while(bd < i && j < key.MaxBadBytes)
                {
                    
                    bd = key.getBadByte(j);
                    j++;
                }
                
                if(bd == i)
                {
                    inputStream.ReadByte();
                    continue;
                }
                Console.WriteLine(-key.getCurByte((int)(ks % key.MaxCryptoLength)));
                outputStream.WriteByte((byte)ChangeByte(inputStream.ReadByte(), -key.getCurByte((int)(ks % key.MaxCryptoLength))));
                Console.WriteLine("Printed at " + i + " " + j + " " + bd + " " + ks);
                ks++;
            }

            inputStream.Close();
            outputStream.Close();
        }

        public override void Encrypt(FileInfo input, FileInfo output)
        {
            if(key == null)
            {
                Console.WriteLine("Hard key is null");
                return;
            }

            FileStream inputStream = input.OpenRead();
            FileStream outputStream = output.OpenWrite();

            int j = 0;

            Random rnd = new Random();

            long i = 0;
            while(j < key.MaxBadBytes)
            {
                int bd = key.getBadByte(j);

                CustomProgressBar.update((int)(j * 50 / key.MaxBadBytes));
                
                if(j == 0 || (bd - key.getBadByte(j - 1)) == 1)
                {
                    outputStream.WriteByte((byte)rnd.Next(1, 256));
                    j++;
                    continue;
                }

                for (bd--; bd > key.getBadByte(j - 1); bd--)
                {
                    Console.WriteLine(key.getCurByte((int)(i % key.MaxCryptoLength)));
                    outputStream.WriteByte((byte)ChangeByte(inputStream.ReadByte(), key.getCurByte((int)(i % key.MaxCryptoLength))));
                    Console.WriteLine("Printed at " + i + " " + j);
                    i++;
                }

                outputStream.WriteByte((byte)rnd.Next(1, 256));
                j++;
            }

            for(;i < inputStream.Length; i++)
            {
                CustomProgressBar.update(50+(int)(i * 50 / inputStream.Length));
                
                outputStream.WriteByte((byte)ChangeByte(inputStream.ReadByte(), key.getCurByte((int)(i % key.MaxCryptoLength))));
                
            }

            inputStream.Close();
            outputStream.Close();
        }

        private int ChangeByte(int Byte, int value)
        {
            return (Byte + value  + 256) % 256;
        }

        public override string GetCryptoType()
        {
            return ContentType;
        }

        public override void SetKey(FileInfo file)
        {
            key = new HardKey(file);
        }
    }
}
