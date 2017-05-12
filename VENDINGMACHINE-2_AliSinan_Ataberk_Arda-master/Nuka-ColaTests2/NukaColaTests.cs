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
    public class NukaColaTests
    {
        [TestMethod()]
        public void QuantumNukaTestCase()
        {
            NukaCola quaNukaCola = new QuantumNuka();
            Assert.AreEqual(300, quaNukaCola.getPrice());
            Assert.AreEqual("Quantum Nuka Cola", quaNukaCola.getName());
        }

        [TestMethod()]
        public void QuantumNukaTestCase2()
        {
            NukaCola quaNukaCola = new QuantumNuka();
            Assert.IsInstanceOfType(quaNukaCola, typeof(NukaCola));
        }

        [TestMethod()]
        public void IceNukaTestCase()
        {
            NukaCola iceNukaCola = new IceNuka();
            Assert.AreEqual(200, iceNukaCola.getPrice());
            Assert.AreEqual("Ice Nuka Cola", iceNukaCola.getName());
        }

        [TestMethod()]
        public void IceNukaTestCase2()
        {
            NukaCola iceNukaCola = new IceNuka();
            Assert.IsInstanceOfType(iceNukaCola, typeof(NukaCola));
        }

        [TestMethod()]
        public void CartCurtNukaTestCase()
        {
            NukaCola cartcurtNukaCola = new Cartcurt();
            Assert.AreEqual(50, cartcurtNukaCola.getPrice());
            Assert.AreEqual("Cart Curt Nuka Cola", cartcurtNukaCola.getName());
        }

        [TestMethod()]
        public void CartCurtNukaTestCase2()
        {
            NukaCola cartcurtNukaCola = new Cartcurt();
            Assert.IsInstanceOfType(cartcurtNukaCola, typeof(NukaCola));
        }

        [TestMethod()]
        public void RedNukaTestCase()
        {
            NukaCola rednuka = new RedNukaCola();
            Assert.AreEqual(500, rednuka.getPrice());
            Assert.AreEqual("Red Nuka Cola", rednuka.getName());
        }

        [TestMethod()]
        public void RedNukaTestCase2()
        {
            NukaCola rednuka = new RedNukaCola();
            Assert.IsInstanceOfType(rednuka, typeof(NukaCola));
        }

    }
}