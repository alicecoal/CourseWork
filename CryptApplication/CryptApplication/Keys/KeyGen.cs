using CryptApplication.Exceptions;
using CryptApplication.Keys.Contents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Utils
{
    class KeyGen
    {
        private string fileName = "";
        private readonly string extension = ".key";

        private readonly string fileNameFormat = "T-sss-SSSS-n";

        private readonly string lowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
        private readonly string upperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly string numbers = "0123456789";

        private IContent[] contents = {new EasyContent(), new MediumContent()};

        public KeyGen(string path, string type)
        {
            fileName = path + "\\";

            GenerateName(type);

            FileInfo file = new FileInfo(fileName);
            if (file.Exists)
            {
                throw new KeyException("Key already exists");
            }

            file.Create().Close();

            GenerateContent(type);
        }

        private void GenerateName(string type)
        {
            Random random = new Random();

            for(int i = 0; i < fileNameFormat.Length; i++)
            {
                switch (fileNameFormat[i])
                {
                    case 'T':
                        fileName += type;
                        break;

                    case 's':
                        fileName += lowerAlphabet[random.Next(lowerAlphabet.Length)];
                        break;

                    case 'S':
                        fileName += upperAlphabet[random.Next(upperAlphabet.Length)];
                        break;

                    case 'n':
                        fileName += numbers[random.Next(numbers.Length)];
                        break;

                    default:
                        fileName += fileNameFormat[i];
                        break;
                }
            }

            fileName += extension;
        }

        private void GenerateContent(string type)
        {
            foreach(IContent content in contents)
            {
                if(content.GetContentType().ToUpper() == type.ToUpper())
                {
                    content.GenerateContent(new FileInfo(fileName));
                    break;
                }
            }
        }

        public string getFileName()
        {
            return fileName;
        }
    }
}
