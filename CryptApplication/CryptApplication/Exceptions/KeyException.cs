using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptApplication.Exceptions
{
    [Serializable]
    class KeyException : Exception
    {
        public KeyException()
        {
            Console.WriteLine("Default Exception at Key process");
        }

        public KeyException(string message) : base(message)
        {
            Console.WriteLine("Exception at Key process: " + message);
        }
    }
}
