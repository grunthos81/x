using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ConsoleApp1
{
    class p16
    {
        public static BigInteger numDigits(BigInteger a)
        {
            BigInteger total = new BigInteger(0);
            while (a > 0)
            {
                total += a % 10;
                a /= 10;
            }
            return total;
        }
        public static void Main(String[] args)
        {
            BigInteger num = new BigInteger(Math.Pow(2, 1000));
            Console.WriteLine(numDigits(num));
        }
    }
}
