using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class HighestTwoNumbers
    {
        // return an array containing the highest and 2nd highest numbers (in that order) from the input array 
        public int[] HighestTwo (int[] input)
        {
            // garbage in, garbage out
            if (input == null) return null;
            else if (input.Length < 2) return input;
            else
            {
                Array.Sort<int>(input);
                return new int[] { input[input.Length - 1], input[input.Length - 2] };
            }
        }

        // return an array containing the highest and 2nd highest numbers (in that order) from the input array 
        public int[] HighestTwoFaster(int[] input)
        {
            // garbage in, garbage out
            if (input == null) return null;
            else if (input.Length < 2) return input;
            else
            {
                int i1 = int.MinValue, i2 = int.MinValue;
                for (int i=0; i<input.Length; i++)
                {
                    int v = input[i];
                    if (v > i1) { i2 = i1; i1 = v; }
                    else if (v > i2) i2 = v;
                }
                return new int[] { i1, i2 };
            }
        }
    }
}
