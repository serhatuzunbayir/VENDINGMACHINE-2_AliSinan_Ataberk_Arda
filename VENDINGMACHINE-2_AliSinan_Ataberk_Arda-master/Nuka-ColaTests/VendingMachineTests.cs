using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nuka_Cola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola.Tests
{
    [TestClass()]
    public class VendingMachineTests
    {
        [TestMethod()]
        public void getTotalCoinTest()
        {
            VendingMachine a = new VendingMachine();
            a.addCoin(100);
            int actual = a.getTotalCoin();
            int expected = 100;
            Assert.AreEqual(expected,actual);
        }

        [TestMethod()]
        public void addCoinTest()
        {
            
            Assert.Fail();
        }

        [TestMethod()]
        public void DisplayDrinkSelectionMenuTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SelectionScreenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SelectionScreenSubTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SelectionTest()
        {
            Assert.Fail();
        }
    }
}