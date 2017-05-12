using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    // Abstract class for cola object
    public abstract class NukaCola
    {
        private int price;
        private string name;


        // Function for get price
        public int getPrice()
        {
            return price;
        }

        // Function for get name
        public string getName()
        {
            return name;
        }

        // Function for set price
        public void setPrice(int price)
        {
            this.price = price;
        }

        // Function for set name
        public void setName(string name)
        {
            this.name = name;
        }
    }

    // Sub-Class for cola object and sets name and price
    public class QuantumNuka : NukaCola
    {
        public QuantumNuka()
        {
            this.setName("Quantum Nuka Cola");
            this.setPrice(300);
        }
    }

    // Sub-Class for cola object and sets name and price
    public class IceNuka : NukaCola
    {
        public IceNuka()
        {
            this.setName("Ice Nuka Cola");
            this.setPrice(200);
        }
    }

    public class RedNukaCola : NukaCola
    {
        public RedNukaCola()
        {
            this.setName("Red Nuka Cola");
            this.setPrice(500);
        }
    }

    // Sub-Class for cola object and sets name and price
    public class Cartcurt : NukaCola
    {
        public Cartcurt()
        {
            this.setName("Cart Curt Nuka Cola");
            this.setPrice(50);
        }
    }
}
