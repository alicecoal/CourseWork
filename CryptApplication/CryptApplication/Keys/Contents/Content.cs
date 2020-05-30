using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys.Contents
{
     interface IContent
    {
        string GetContentType();

        void GenerateContent(FileInfo file);

        bool ValidateContent(FileInfo file);
    }
}
