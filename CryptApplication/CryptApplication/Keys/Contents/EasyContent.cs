using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Keys.Contents
{
    class EasyContent : IContent
    {
        private readonly string ContentType = "Easy";

        public void GenerateContent(FileInfo file)
        {
            FileStream fileStream = new FileStream(file.FullName, FileMode.Open);

            Random rnd = new Random();
            byte power = (byte)rnd.Next(1,256);

            fileStream.WriteByte(power);

            fileStream.Close();
        }

        public bool ValidateContent(FileInfo file)
        {
            FileStream fileStream = new FileStream(file.FullName, FileMode.Open);

            byte[] arr = null;
            fileStream.Read(arr, 0, (int)fileStream.Length);

            fileStream.Close();

            return true;
        }

        public string GetContentType()
        {
            return ContentType;
        }
    }
}
