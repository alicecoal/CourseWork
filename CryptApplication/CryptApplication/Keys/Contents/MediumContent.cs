using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys.Contents
{
    class MediumContent : IContent

    {
        private readonly string ContentType = "Medium";
        private readonly int MaxBytes = 1024;

        public void GenerateContent(FileInfo file)
        {
            FileStream fileStream = new FileStream(file.FullName, FileMode.Open);

            Random rnd = new Random();
            for (int i = 0; i < MaxBytes; i++)
            {
                byte power = (byte)rnd.Next(1, 256);
                fileStream.WriteByte(power);
            }

            fileStream.Close();
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
