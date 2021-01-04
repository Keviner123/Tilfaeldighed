using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    class Program
    {
        public static string GenerateRandomStringUsingRNGCryptoServiceProvider(int length)
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);

            }
        }

        public static string GenerateRandomStringUsingRandom(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            return (new String(stringChars));
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(GenerateRandomStringUsingRNGCryptoServiceProvider(10));
            }
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            Console.ReadLine();

        }
    }
}
