using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class p14
    {
        public static void Main(String[] args)
        {
            Dictionary<long, long> chains = new Dictionary<long,long>();
            chains[1] = 1;
            chains[2] = 2;
            
            for (int i = 3; i < 1000000; i++)
            {
                
                if (chains.ContainsKey(i)) { continue; }
                long currNum = i;
                bool found = false;
                List<long> currChain = new List<long>();
                currChain.Add(i);
                while (found == false)
                {
                    if (currNum % 2 == 0) { currNum /= 2; }
                    else { currNum = (3 * currNum) + 1; }
                    currChain.Add(currNum);
                    if (chains.ContainsKey(currNum)) { found = true; }
                }
                for (int j = 0; j < currChain.Count; j++)
                {
                    chains[currChain[j]] = (currChain.Count - j - 1) + chains[currNum];
                    chains[currChain[j] * 2] = chains[currChain[j]] + 1;
                }
                currChain.Clear();
            }
            long biggestVal = 0;
            long biggestKey = 0;
            foreach (KeyValuePair<long,long> n in chains)
            {
                if ((n.Key < 1000000) && ( n.Value > biggestVal))
                {
                    biggestVal = n.Value;
                    biggestKey = n.Key;
                }
            }
            Console.WriteLine(biggestKey);
        }
    }
}
