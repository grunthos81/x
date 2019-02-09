using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sieve
    {

        public Boolean[] getSieve(int size)
        {
            Boolean[] nums = new bool[size];
            for(int i = 0; i < size; i++) { nums[i] = true; }
            nums[0] = false;
            nums[1] = false;
            int p = 2;
            while (p*p <= size)
            {
                if (nums[p] == true)
                {
                    for(int i = p*2; i < size; i+=p)
                    {
                        nums[i] = false;
                    }
                }
                p++;
            }
            return nums;
        }
    }
}
