using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityDemoAppNUnitTests
{
    [TestFixture]
    public class NunitTests
    {
        [Test]
        public void TransferFunds()
        {
            Assert.AreEqual(250m, 250m);
        }

        [Test]
        public void TransferFunds1()
        {
            Assert.AreEqual(250m, 250m);
        }
    }
}
