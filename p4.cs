using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p4
    {
        public static bool palNumber(int num)
        {
            int a = num;
            int reverse = 0;
            while (a > 0)
            {
                int remainder = a % 10;
                reverse = (reverse * 10) + remainder;
                a = a / 10;
            }
            return (num == reverse);
        }


        public static void Main(String[] args)
        {
            int largest = 0;
            isPalindrome p = new isPalindrome();
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    
                    if (palNumber(i*j) && i*j > largest)
                    {
                        largest = i * j;
                    }
                }
            }
            Console.WriteLine(largest);
        }
    }
}
