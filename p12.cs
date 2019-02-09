using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p12
    {
        public static int getFactors(int n)
        {
            Dictionary<int, int> factors = new Dictionary<int, int>();
            int start = 2; 
            while (n!= 1)
            {
                if (n%start == 0)
                {
                    if (factors.ContainsKey(start)) { factors[start]++; }
                    else { factors[start] = 1; }
                    n /= start;
                }
                else { start += 1; }
            }
            int numFactors = 1;
            foreach (KeyValuePair<int,int> num in factors) { numFactors *= (num.Value+1); }
            return numFactors;
        }
        public static void Main(String[] args)
        {

            int tNum = 28;
            int add = 8;
            while (getFactors(tNum) < 500)
            {
                tNum += add;
                add += 1;
            }
            Console.WriteLine(tNum);
        }
    }
}
//getFactors works by taking a tally of the prime factors of a number. 
//example: 72 has prime factors 2^3 * 3^2 or three twos and two threes.
//we must then add 1 to the exponents and multiply them. So for 72 we have (3+1)*(2+1) = 4*3 = 12