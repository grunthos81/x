using System;
using System.Collections.Generic;
using System.Text;

namespace projecteuler
{
    class Fibonacci
    {
        static List<long> FibList(int num)
        {
            List<long> vals = new List<long>();
            vals.Add(0);
            vals.Add(1);
            vals.Add(1);
            if (num == 1)
            {
                vals.RemoveAt(2);
                vals.RemoveAt(1);
                return vals;
            }
            if (num == 2)
            {
                vals.RemoveAt(2);
                return vals;
            }
            for (int i = 4; i <= num; i++)
            {
                long first = vals[vals.Count - 1];
                long second = vals[vals.Count - 2];
                vals.Add(first + second);
            }
            return vals;
        }

        static long FibNum(int num)
        {
            if (num == 1) { return 0; }
            if (num == 2) { return 1; }
            long a = 0;
            long b = 1;
            for(int i = 3; i <= num; i++)
            {
                long c = b + a;
                a = b;
                b = c;
            }
            return b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I do Fibonacci numbers");
            Console.WriteLine("Would you like 1. the nth Fibonacci number, or 2. the n first Fibonacci numbers?");
            int choice = 0;
            while ((choice != 1) & (choice != 2))
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                    if ((choice != 1) & (choice != 2))
                    {
                        Console.WriteLine("Needs to be 1 or 2");
                    }
                }
                catch (System.FormatException ex)
                { Console.WriteLine("Digits only please"); }
            }
            Console.WriteLine("Thank you.");
            Console.WriteLine("If you chose 1, pick a number between 1 and 25 to see the nth" +
                "Fibonacci number.");
            Console.WriteLine("If you chose 2, pick a number between 1 and 25 to see all the" +
                "Fibonacci numbers up to the nth in the sequence.");
            int num = 0;
            while ((num < 1) | (num > 25))
            {
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    if ((num < 1) | (num > 25))
                    {
                        Console.WriteLine("Needs to be between 1 and 25");
                    }
                }
                catch (System.FormatException ex)
                { Console.WriteLine("Digits only please"); }
            }
            if (choice == 1) { Console.WriteLine(FibNum(num)); }
            if (choice == 2)
            {
                foreach(long element in FibList(num)) { Console.WriteLine(element); }
            }
        }
        

    }
}
