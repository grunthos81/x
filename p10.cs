using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p10
    {
        public static void Main(String[] args)
        {
            sieve s = new sieve();
            bool[] nums = s.getSieve(2000000);
            long total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]) { total += i; }
            }
            Console.WriteLine(total);
        }
    }
}
//notes: easy one. Sieve all the primes below 2*10^6 and add them up. 
