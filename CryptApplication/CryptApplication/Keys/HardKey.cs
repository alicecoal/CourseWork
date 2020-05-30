using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys
{
    class HardKey
    {

        public int MaxBadBytes = 1024 * 1024;
        public int MaxCryptoLength = 1024 * 1024;

        private int[] BadBytes;
        private byte[] codes;

        public HardKey(FileInfo key)
        {
            FileStream input = key.OpenRead();

            string current = "";
            while (true)
            {
                char x = (char)input.ReadByte();
                if (x == ' ') break;
                current += x;
            }

            int numbers = int.Parse(current);
            BadBytes = new int[numbers];
            codes = new byte[MaxCryptoLength];

            int j = 0;
            while(numbers-- > 0)
            {
                current = "";
                while (true)
                {
                    char x = (char)input.ReadByte();
                    if (x == ' ') break;
                    current += x;
                }

                BadBytes[j] = int.Parse(current);
                j++;
            }

            input.Read(codes, 0, MaxCryptoLength);

            input.Close();
        }

        public HardKey(FileInfo source, FileInfo sKey)
        {
            FileStream input = source.OpenRead();
            FileStream key = sKey.OpenWrite();

            byte[] code = Encoding.ASCII.GetBytes(MaxBadBytes.ToString() + " ");
            int bts = MaxBadBytes;
            Random rnd = new Random();

            key.Write(code, 0, code.Length);

            long j = 0;
            int ll;
            for (long i = 0; i < input.Length; i++)
            {
                if (bts >= 1) ll = rnd.Next(1, bts); 
                else ll = 0;
                while (ll-- > 0)
                {
                    code = Encoding.ASCII.GetBytes(j.ToString() + " ");
                    key.Write(code, 0, code.Length);
                    bts--;
                    j++;
                }
                j++;
            }
            ll = bts;
            while (ll-- > 0)
            {
                code = Encoding.ASCII.GetBytes(j.ToString() + " ");
                key.Write(code, 0, code.Length);
                j++;
            }

            for (long i = 0; i < MaxCryptoLength; i++)
            {
                key.WriteByte((byte)rnd.Next(1, 256));
            }

            input.Close();
            key.Close();
        }

        public int getBadByte(int index)
        {
            return BadBytes[index];
        }

        public int getCurByte(int index)
        {
            return codes[index];
        }
    }


}
