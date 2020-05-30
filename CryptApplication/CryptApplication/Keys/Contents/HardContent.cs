using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys.Contents
{
    class HardContent : IContent
    {

        private readonly string ContentType = "Hard";
        public void GenerateContent(FileInfo file)
        {
            Console.WriteLine("Hard generate content stopped!");
            return;
        }

        public string GetContentType()
        {
            return ContentType;
        }

        public bool ValidateContent(FileInfo file)
        {
            return true;
        }
    }
}
