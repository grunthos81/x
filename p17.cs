using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p17alt
    {
        public static void Main(String[] args)
        {
            string[] hundreds = {"","onehundredand", "twohundredand", "threehundredand", "fourhundredand",
            "fivehundredand", "sixhundredand", "sevenhundredand", "eighthundredand", "ninehundredand"};
            string[] tens = {"", "", "twenty", "thirty", "forty", "fifty",
                "sixty", "seventy", "eighty", "ninety"};
            string[] units = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
            "eighteen", "nineteen"};
            int total = 11;
            for(int i = 1; i < 1000; i++)
            {
                if (i % 100 == 0)
                {
                    total += hundreds[i / 100].Length - 3;
                    continue;
                }
                if (i % 100 < 20)
                {
                    total += (hundreds[i / 100] + units[i % 100]).Length;
                }
                else
                {
                    total += (hundreds[i / 100] + tens[(i % 100)/10] + units[i % 10]).Length;
                }

            }
            Console.WriteLine(total);
        }
    }
}
