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
        // Test for Vending Machine object is created
        [TestMethod()]
        public void VendingMachine()
        {
            VendingMachine a = new VendingMachine();
            Assert.IsTrue(a.instanceVendingMachine);
        }

        // Test for get balance
        [TestMethod()]
        public void getTotalCoinTest()
        {
            VendingMachine a = new VendingMachine();
            int expected=100;
            a.addCoin(100);
            int actual = a.getTotalCoin();
            Assert.AreEqual(expected,actual);
        }

        // Test for adding coins to balance
        [TestMethod()]
        public void addCoinTest()
        {
            VendingMachine a = new VendingMachine();
            int expected = 20;
            a.addCoin(20);
            int actual = a.getTotalCoin();
            Assert.AreEqual(expected, actual);
        }

       

    }
}