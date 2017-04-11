using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    abstract class NukaCola
    {
        private int price;
        private string name;

        public int getPrice()
        {
            return price;
        }

        public string getName()
        {
            return name;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }

    class QuantumNuka : NukaCola
    {
        public QuantumNuka()
        {
            this.setName("Quantum Nuka Cola");
            this.setPrice(300);
        }
    }

    class IceNuka : NukaCola
    {
        public IceNuka()
        {
            this.setName("Ice Nuka Cola");
            this.setPrice(200);
        }
    }

    class Cartcurt : NukaCola
    {
        public Cartcurt()
        {
            this.setName("Ice Nuka Cola");
            this.setPrice(200);
        }
    }
}
