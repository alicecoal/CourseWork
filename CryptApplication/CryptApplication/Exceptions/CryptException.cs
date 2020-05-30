using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Exceptions
{
    [Serializable]
    class CryptException : Exception
    {
        public CryptException()
        {
            Console.WriteLine("Default Exception at Crypt process");
        }

        public CryptException(string message) : base(message)
        {
            Console.WriteLine("Exception at Crypt process: " + message);
        }
    }
}
