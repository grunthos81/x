using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p3
    {
        public static void Main(String[] args)
        {
            long n = 600851475143;
            long p = 2; 
            while (n > p)
            {
                if (n % p == 0)
                {
                    n = n / p;
                }
                else
                {
                    p += 1;
                }
            }
            Console.WriteLine(n);
        }
    }
}
