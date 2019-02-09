using System;

namespace ConsoleApp1
{
    class p1
    {
        static void Main(string[] args)
        {
            int total = 0; 
            for(int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) ||(i%5==0))
                {
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}
