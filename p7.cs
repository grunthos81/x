using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p7
    {
        public static void Main(String[] args)
        {
            sieve s = new sieve();
            bool[] nums = s.getSieve(200000);
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == true) { count += 1; }
                if (count == 10001)
                {
                    Console.WriteLine(i);
                    break;

                }
            }

        }
    }
}
