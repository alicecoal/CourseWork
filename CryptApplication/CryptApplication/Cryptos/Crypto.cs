using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Cryptos
{
    abstract class Crypto
    {
        abstract public string GetCryptoType();

        abstract public void SetKey(FileInfo file);

        abstract public void Encrypt(FileInfo input, FileInfo output);

        abstract public void Decrypt(FileInfo input, FileInfo output);
    }
}
