using System;
using Katas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.Tests
{
    [TestClass()]
    public class ValidateGroupsTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            ValidateGroups vg = new ValidateGroups();
            Assert.IsTrue(vg.IsValid(""));
            Assert.IsTrue(vg.IsValid("{[()]}"));
            Assert.IsTrue(vg.IsValid("{[([])([[]])]}"));
            Assert.IsFalse(vg.IsValid("]"));
            Assert.IsFalse(vg.IsValid("{[(])}"));
            Assert.IsFalse(vg.IsValid("{()]}"));
            Assert.IsFalse(vg.IsValid("{()"));
        }
    }
}
