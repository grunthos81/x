using System;
using System.Collections.Generic;
using System.Text;

namespace projecteuler
{
    class Primefactors
    {
        static List<int> getPrimeFactors(int n)
        {
            List<int> factors = new List<int>();
            int i = 2;
            while (n >= i)
            {
                if (n % i == 0)
                {
                    if (!(factors.Contains(i)))
                    {
                        factors.Add(i);
                    }
                    n /= i;   
                }
                else { i++; }
            }
            return factors;
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the Prime Factorisation Tool");
            Console.WriteLine("Please pick a number between 2 and 100000000 and I will list all" +
                "prime factors");
            int num = 0;
            while ((num < 2) || (num > 100000000))
            {
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ((num <2) ||(num > 100000000)) { Console.WriteLine("Number must be between 2 and 100000000"); }
                }
                catch(System.FormatException ex)
                {
                    Console.WriteLine("Please only use digits");
                }
                List<int> result = getPrimeFactors(num);
                foreach (int factor in result) { Console.WriteLine(factor); }
                    
            }
        }
    }
}
