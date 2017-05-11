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
        //Test vending machine constructor
        [TestMethod()]
        public void VendingMachineTestCase()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Assert.IsInstanceOfType(vendingMachine, typeof(VendingMachine));
        }

        //Test balance at start. It must start at 0.
        [TestMethod()]
        public void getTotalCoinTest()
        {
            VendingMachine vendingMachine = new VendingMachine();
            Assert.AreEqual(0, vendingMachine.getTotalCoin());
        }

        //Test adding 50 coin
        [TestMethod()]
        public void getTotalCoinTest2()
        {
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.addCoin(50);
            Assert.AreEqual(50, vendingMachine.getTotalCoin());
        }        

        // Test adding 100 coin
        [TestMethod()]
        public void getTotalCoinTest3()
        {
            VendingMachine a = new VendingMachine();
            int expected = 100;
            a.addCoin(100);
            int actual = a.getTotalCoin();
            Assert.AreEqual(expected, actual);
        }

        // Test for adding 25 coin
        [TestMethod()]
        public void addCoinTest()
        {
            VendingMachine a = new VendingMachine();
            int expected = 25;
            a.addCoin(25);
            int actual = a.getTotalCoin();
            Assert.AreEqual(expected, actual);
        }

        //Test for CalculateDiscount function
        [TestMethod()]
        public void CalculateDiscount()
        {
            VendingMachine a = new VendingMachine();
            int expected = 75;
            Assert.AreEqual(expected, a.CalculateDiscount(100));
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

        //Test for IsNumeric function
        [TestMethod()]
        public void IsNumericTest()
        {
            Assert.IsTrue(VendingMachine.IsNumeric("44"));
        }

        //Test for IsNumeric function
        [TestMethod()]
        public void IsNumericTest2()
        {
            Assert.IsFalse(VendingMachine.IsNumeric("Coban"));
        }

        //GiveIcedNuka return string test
        [TestMethod()]
        public void NukaColaWithoutIceTest()
        {
            VendingMachine a = new VendingMachine();
            String expected = "";
            Assert.AreEqual(expected, a.GiveIcedNuka(false));

        }

        //GiveIcedNuka return string test
        [TestMethod()]
        public void NukaColaWithIceTest()
        {
            VendingMachine a = new VendingMachine();
            String expected = "Your brain will freeze...";
            Assert.AreEqual(expected, a.GiveIcedNuka(true));

        }

    }
}