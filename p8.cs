using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class p8
    {
        public static long product(int a, List<int> nums)
        {
            long total = 1;
            for (int i = a; i < a+13; i++)
            {
                total *= nums[i];
            }
            return total;
        }
        public static void Main(String[] args)
        {
            List<int> nums = new List<int>();
            using (var reader = new StreamReader("8.csv"))
            {
                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    int[] n = Array.ConvertAll(values, s => int.Parse(s));
                    foreach (int a in n)
                    {
                        nums.Add(a);
                    }
                }
            }
            long highest = 0;
            for (int i = 0; i < 985; i++)
            {
                long currentProduct = product(i, nums);
                if (currentProduct > highest) { highest = currentProduct; }
            }
            Console.WriteLine(highest);
        }
    }
}
