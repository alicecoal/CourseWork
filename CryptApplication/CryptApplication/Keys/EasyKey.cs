using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys
{
    class EasyKey
    {
        private int code = 0;

        public EasyKey(FileInfo info)
        {
            FileStream input = info.OpenRead();
            Code = input.ReadByte();
            input.Close();
        }

        public int Code { get => code; set => code = value; }
    }
}
