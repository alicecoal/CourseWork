using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys
{
    class MediumKey
    {
        private int[] code;

        public MediumKey(FileInfo info)
        {
            FileStream input = info.OpenRead();
            code = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
                code[i] = input.ReadByte();

            input.Close();
        }

        public int[] Code()
        {
            return code;
        }

        public int Code(int index)
        {
            return code[index];
        }
    }
}
