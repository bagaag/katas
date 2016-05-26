using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class ArrayUtils
    {

        /// <summary>
        /// Generate array of random int values 
        /// </summary>
        /// <param name="len">resulting array length</param>
        /// <param name="lowerBound">lowest random value; default is int.MinValue</param>
        /// <param name="upperBound">highest random value; default is int.MaxValue</param>
        /// <returns></returns>
        public static int[] GenerateInt(int len, int lowerBound = int.MinValue, int upperBound = int.MaxValue)
        {
            Random r = new Random();
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                a[i] = r.Next(lowerBound, upperBound);
            }
            return a;
        }

        public static string Join(int[] array, string delim = ",")
        {
            return string.Join(delim, array.Select(x => x.ToString()).ToArray());
        }

    }
}

namespace KatasTest
{
    using Katas;

    [TestFixture]
    public class ArrayUtilsTest
    {
        [TestCase(0,int.MinValue, int.MaxValue)]
        [TestCase(100000, int.MinValue, int.MaxValue)]
        public void GenerateIntTest(int len, int lowerBound, int upperBound)
        {
            int[] a = ArrayUtils.GenerateInt(len, lowerBound, upperBound);
            Assert.AreEqual(a.Length, len);
            foreach(int i in a)
            {
                Assert.LessOrEqual(i, upperBound);
                Assert.GreaterOrEqual(i, lowerBound);
            }
        }

        [TestCase]
        [Category("ArrayUtils")]
        public void JoinTest()
        {
            int[] a = new int[] { 5, 2, 4, 6 };
            string joined = ArrayUtils.Join(a);
            Assert.AreEqual(joined, "5,2,4,6");
        }
    }
}
