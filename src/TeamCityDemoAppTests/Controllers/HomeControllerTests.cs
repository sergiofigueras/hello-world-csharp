using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCityDemoApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityDemoApp.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod()]
        public void Index1Test()
        {
            Assert.AreEqual(true, true);
            //Assert.AreEqual(true, false, "This is custom failed message");

        }
    }
}