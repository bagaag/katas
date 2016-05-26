using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class HighestTwoNumbers
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();
            int[] a = ArrayUtils.GenerateInt(1000000);
            HighestTwoNumbers htn = new HighestTwoNumbers();
            sw.Start();
            int[] r1 = htn.HighestTwo(a);
            sw.Stop();
            long e1 = sw.ElapsedMilliseconds;
            sw.Restart();
            int[] r2 = htn.HighestTwoFaster(a);
            sw.Stop();
            long e2 = sw.ElapsedMilliseconds;
            Console.WriteLine($"Slow: {ArrayUtils.Join(r1)} in {e1}ms");
            Console.WriteLine($"Fast: {ArrayUtils.Join(r2)} in {e2}ms");
        }

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

namespace KatasTest
{
    [TestFixture]
    public class HighestTwoNumbersTest
    {
            [TestCase()]
            public void HighestTwoTest()
            {
                HighestTwoNumbers htn = new HighestTwoNumbers();
                int[] ret = htn.HighestTwo(new int[] { 3, 8, 3, 10 });
                Assert.IsTrue(new int[] { 10, 8 }.SequenceEqual(ret));

                ret = htn.HighestTwo(new int[] { 10, 8, 3, 10 });
                Assert.IsTrue(new int[] { 10, 10 }.SequenceEqual(ret));

                ret = htn.HighestTwo(new int[] { -1, -10, 1, 0 });
                Assert.IsTrue(new int[] { 1, 0 }.SequenceEqual(ret));

                ret = htn.HighestTwo(new int[] { 6, 3, 6, 7, 98, 5, 1, 34, 5, 4, 3, 34, 5, 5, 2, 1, 51, 15, 6, 7, 76, 7, 8, 34, 36, 43, 4, 3, 5, 56 });
                Assert.IsTrue(new int[] { 98, 76 }.SequenceEqual(ret));
            }

            [TestCase()]
            public void HighestTwoFasterTest()
            {
                HighestTwoNumbers htn = new HighestTwoNumbers();
                int[] ret = htn.HighestTwoFaster(new int[] { 3, 8, 3, 10 });
                Assert.IsTrue(new int[] { 10, 8 }.SequenceEqual(ret));

                ret = htn.HighestTwoFaster(new int[] { 10, 8, 3, 10 });
                Assert.IsTrue(new int[] { 10, 10 }.SequenceEqual(ret));

                ret = htn.HighestTwoFaster(new int[] { -1, -10, 1, 0 });
                Assert.IsTrue(new int[] { 1, 0 }.SequenceEqual(ret));

                ret = htn.HighestTwoFaster(new int[] { 6, 3, 6, 7, 98, 5, 1, 34, 5, 4, 3, 34, 5, 5, 2, 1, 51, 15, 6, 7, 76, 7, 8, 34, 36, 43, 4, 3, 5, 56 });
                Assert.IsTrue(new int[] { 98, 76 }.SequenceEqual(ret));
            }

            [TestCase()]
            public void HighestTwoTestNull()
            {
                HighestTwoNumbers htn = new HighestTwoNumbers();
                Assert.IsNull(htn.HighestTwo(null));
            }

            [TestCase()]
            public void HighestTwoTestEmpty()
            {
                HighestTwoNumbers htn = new HighestTwoNumbers();
                int[] ret = htn.HighestTwo(new int[] { });
                Assert.IsTrue(new int[] { }.SequenceEqual(ret));
            }

            [TestCase()]
            public void HighestTwoTestOne()
            {
                HighestTwoNumbers htn = new HighestTwoNumbers();
                int[] ret = htn.HighestTwo(new int[] { });
                Assert.IsTrue(new int[] { 1 }.SequenceEqual(htn.HighestTwo(new int[] { 1 })));
            }
        }
    }
}