using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class River
    {
        public static int CountAliveFishes(int[] fishWeight, int[] fishDirection)
        {
            if (fishWeight.Length != fishDirection.Length)
                throw new ArgumentException("arrays have different lenghts");

            int aliveCounter = 0;
            Stack<int> upstreamSwimmers = new Stack<int>();
            for(int i=0; i<fishWeight.Length; i++)
            {
                if(fishDirection[i] == 0)
                {
                    if( EatUpstreamers(fishWeight[i],ref upstreamSwimmers))
                    {
                        aliveCounter++;
                    }
                }
                else
                {
                    upstreamSwimmers.Push(fishWeight[i]);
                }
            }

            aliveCounter += upstreamSwimmers.Count;

            return aliveCounter;
        }

        public static bool EatUpstreamers(int eaterWeight,ref Stack<int> upstreamSwimmers)
        {
            List<int> swimmersList = upstreamSwimmers.ToList();
            foreach (int upstreamer in swimmersList)
            {
                if(upstreamer < eaterWeight)
                {
                    upstreamSwimmers.Pop();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
