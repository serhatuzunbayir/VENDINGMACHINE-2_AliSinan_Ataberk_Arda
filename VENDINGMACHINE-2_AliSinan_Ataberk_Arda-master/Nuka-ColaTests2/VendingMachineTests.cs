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
        public void VendingMachineTestCase()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Assert.IsInstanceOfType(vendingMachine, typeof(VendingMachine));
        }

        [TestMethod()]
        public void getTotalCoinTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Assert.AreEqual(0, vendingMachine.getTotalCoin());
        }

        [TestMethod()]
        public void getTotalCoinTest2()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.addCoin(50);
            Assert.AreEqual(50, vendingMachine.getTotalCoin());
        }        

        // Test for get balance
        [TestMethod()]
        public void getTotalCoinTest3()
        {
            VendingMachine a = new VendingMachine();
            int expected = 100;
            a.addCoin(100);
            int actual = a.getTotalCoin();
            Assert.AreEqual(expected, actual);
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

        //Test for discount 
        [TestMethod()]
        public void MakeDiscountToIceNukaCola()
        {
            VendingMachine a = new VendingMachine();
            NukaCola iceNukaCola = new IceNuka();
            int expected = 150;
            int actual = (int)a.CalculateDiscount(iceNukaCola.getPrice()); //%25 discount to 200
            Assert.AreEqual(expected, actual);
        }

        //Test for discount 
        [TestMethod()]
        public void MakeDiscountToQuantumNukaCola()
        {
            VendingMachine a = new VendingMachine();
            NukaCola quantumNukaCola = new QuantumNuka(); 
            int expected = 225; 
            int actual = (int)a.CalculateDiscount(quantumNukaCola.getPrice()); //%25 discount to 300
            Assert.AreEqual(expected, actual);
        }

        //Test for discount 
        [TestMethod()]
        public void MakeDiscountToCartCurtNukaCola()
        {
            VendingMachine a = new VendingMachine();
            NukaCola cartCurtNukaCola = new Cartcurt();
            int expected = 37;
            int actual = (int)a.CalculateDiscount(cartCurtNukaCola.getPrice()); //%25 discount to 50
            Assert.AreEqual(expected, actual);
        }

        /*[TestMethod()]
        public void IsNumericTest()
        {
            Assert.IsTrue(VendingMachine.IsNumeric("44"));
        }

        [TestMethod()]
        public void IsNumericTest2()
        {
            Assert.IsTrue(VendingMachine.IsNumeric("Sinan"));
        }*/

    }
}