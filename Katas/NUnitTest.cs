using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas
{
    [TestFixture]
    public class NUnitTest
    {
        [TestCase(true, ExpectedResult = false)]
        [TestCase(false, ExpectedResult = true)]
        public bool Opposite(bool b)
        {
            return !b;
        }

        [SetUp]
        protected void SetUp()
        {
        }

    }
}
