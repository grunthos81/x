using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p2
    {
        public static void Main(String[] args)
        {
            int total = 2;
            int a = 1;
            int b = 2; 
            while(b < 4000000)
            {
                int c = a + b;
                if (c%2 == 0) { total += c; }
                a = b;
                b = c; 
            }
            Console.WriteLine(total);
        }
                
    }
}
