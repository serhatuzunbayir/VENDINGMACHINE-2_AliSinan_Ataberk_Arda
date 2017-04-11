using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    class VendingMachine
    {
        private int totalCoin;
        private int selection;
        NukaCola icenuka = new IceNuka();
        NukaCola quantumnuka = new QuantumNuka();
        NukaCola cartcurt = new Cartcurt();

        public int getTotalCoin()
        {
            return totalCoin;
        }

        public void addCoin(int coin)
        {
            totalCoin += coin;
        }


        public void DisplayDrinkSelectionMenu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------         1 -> Ice Cold Nuka Cola  (200)      ---------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------         2 -> Quantum Nuka Cola  (300)      ---------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------         3 -> Cart Curt Nuka Cola  (50)      ---------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please select a drink: ");
            selection = Convert.ToInt32(Console.ReadLine());
            if (selection > 3)
            {
                Console.WriteLine("Hatali secim yaptiniz lutfen seciminizi tekrar yapiniz");
                this.DisplayDrinkSelectionMenu();
            }

            Selection();

        }

        public void Selection()
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Harika bir secim" + icenuka.getName());
                    if (totalCoin < icenuka.getPrice())
                    {
                        Console.WriteLine("Az daha para at");
                    }
                    else
                    {
                        totalCoin -= icenuka.getPrice();
                        Console.WriteLine("Para ustunuz" + totalCoin);
                    }
                    break;
                case 2:
                    Console.WriteLine("Harika bir secim" + quantumnuka.getName());
                    if (totalCoin < quantumnuka.getPrice())
                    {
                        Console.WriteLine("Az daha para at");
                    }
                    else
                    {
                        totalCoin -= quantumnuka.getPrice();
                        Console.WriteLine("Para ustunuz" + totalCoin);
                    }
                    break;
                case 3:
                    Console.WriteLine("Harika bir secim" + cartcurt.getName());
                    if (totalCoin < cartcurt.getPrice())
                    {
                        Console.WriteLine("Az daha para at");
                    }
                    else
                    {
                        totalCoin -= cartcurt.getPrice();
                        Console.WriteLine("Para ustunuz" + totalCoin);
                    }
                    break;

            }
        }


        

        

        
    } //end of VendingMachine class
}
