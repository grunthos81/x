using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p15
    {
        public static void Main(String[] args)
        {
            List<List<long>> pascal = new List<List<long>>();
            List<long> startList = new List<long>();
            startList.Add(1);
            pascal.Add(startList);
            for(int i = 0; i < 41; i++)
            {
                List<long> newList = new List<long>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) { newList.Add(1); }
                    else if (j == i) { newList.Add(1); }
                    else { newList.Add(pascal[i][j-1] + pascal[i][j]); }
                }
                pascal.Add(newList);

            }
            Console.WriteLine(pascal[41][20]);
        }
    }
}
