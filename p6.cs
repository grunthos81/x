using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p6
    {
        public static void Main(String[] args)
        {
            //sum of squares can be found using Gauss' formula n(n+1)(2n+1)/6
            //sum of naturals is just n(n+1)/2, a triangular number
            long sumOfSquares = (100 * 101 * 201) / 6;
            long justTheSum = (long)Math.Pow((100*101)/2,2);
            Console.WriteLine(justTheSum-sumOfSquares);
        }

    }
}
