using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Utils
{
    class Validator
    {
        public static bool ValidateFileToCrypt(string path)
        {
            return File.Exists(path);
        }

        public static bool ValidateDirectoryToCrypt(string path)
        {
            return Directory.Exists(path);
        }

        public static bool ValidateKey(string path)
        {
            return File.Exists(path); //TODO validate content
        }
    }
}
