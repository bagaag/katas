using Microsoft.VisualStudio.TestTools.UnitTesting;
using Katas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.Tests
{
    [TestClass()]
    public class HighestTwoNumbersTests
    {
        [TestMethod()]
        public void HighestTwoTest()
        {
            HighestTwoNumbers htn = new HighestTwoNumbers();
            int[] ret = htn.HighestTwo(new int[] { 3, 8, 3, 10 });
            Assert.IsTrue(new int[] { 10, 8 }.SequenceEqual(ret));

            ret = htn.HighestTwo(new int[] { 10, 8, 3, 10 });
            Assert.IsTrue(new int[] { 10, 10 }.SequenceEqual(ret));

            ret = htn.HighestTwo(new int[] { -1, -10, 1, 0 });
            Assert.IsTrue(new int[] { 1, 0 }.SequenceEqual(ret));

            ret = htn.HighestTwo(new int[] { 6,3,6,7,98,5,1,34,5,4,3,34,5,5,2,1,51,15,6,7,76,7,8,34,36,43,4,3,5,56 });
            Assert.IsTrue(new int[] { 98, 76 }.SequenceEqual(ret));
        }

        [TestMethod()]
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

        [TestMethod()]
        public void HighestTwoTestNull()
        {
            HighestTwoNumbers htn = new HighestTwoNumbers();
            Assert.IsNull(htn.HighestTwo(null)); 
        }

        [TestMethod()]
        public void HighestTwoTestEmpty()
        {
            HighestTwoNumbers htn = new HighestTwoNumbers();
            int[] ret = htn.HighestTwo(new int[] { });
            Assert.IsTrue(new int[] { }.SequenceEqual(ret));
        }

        [TestMethod()]
        public void HighestTwoTestOne()
        {
            HighestTwoNumbers htn = new HighestTwoNumbers();
            int[] ret = htn.HighestTwo(new int[] { });
            Assert.IsTrue(new int[] { 1 }.SequenceEqual(htn.HighestTwo(new int[] { 1 })));
        }
    }
}