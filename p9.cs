using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class p9
    {
        public static void Main(String[] args)
        {
            bool found = false;
            for (int m = 1; m < 32; m++)
            {
                for (int n = 1; n < 32; n++)
                {
                    int a = 2 * m * n;
                    int b = (int)Math.Pow(m, 2) - (int)Math.Pow(n, 2);
                    int c = (int)Math.Pow(m, 2) + (int)Math.Pow(n, 2);
                    if((a+b+c == 1000) && (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)))
                    {
                        Console.WriteLine(a * b * c);
                        found = true;
                        break;
                    }
                    if (found) { break; }
                    
                }
            }
        }
    }
}
//notes - https://en.wikipedia.org/wiki/Pythagorean_triple#Proof_of_Euclid's_formula this link was a great help. 
//since the total cannot exceed 1000 then m and n cannot exceed sqrt(1000) or 31. 
//there's probably a quicker way to do it, but since this implementation uses 31^2 (961) iterations it's already pretty
//fast, so I'm just going to leave it. 
