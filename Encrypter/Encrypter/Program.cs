using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Krypteret: " + Encrypter.Encrypt("HELLOWORLD"));
            Console.WriteLine("Dekrypteret: " + Encrypter.Decrypt(Encrypter.Encrypt("HELLOWORLD")));

            Console.ReadKey();
        }
    }
}
