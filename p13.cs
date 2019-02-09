using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class p13
    {
        public static void Main(String[] args)
        {
            using (var reader = new StreamReader("13.csv"))
            {
                long total = 0;
                while (!reader.EndOfStream)
                {
                    
                    var line = reader.ReadLine();
                    total += long.Parse(line.Substring(0,11));
                    
                }
                Console.WriteLine(total.ToString().Substring(0,10));
            }
        }
    }
}
