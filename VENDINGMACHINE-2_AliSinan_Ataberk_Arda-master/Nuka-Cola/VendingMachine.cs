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

        public void SelectionScreen()
        {
            Console.WriteLine("--- Add a Coin --- Only 25 - 50 - 100");
            bool isSelected = true;
            while (isSelected)
            {
                int coin;
                string cikis;
                Console.WriteLine("Para atmaniz bekleniyor");
                coin = Convert.ToInt32(Console.ReadLine());
                if (coin == 25 || coin == 50 || coin == 100)
                {
                    this.addCoin(coin);
                }
                else
                {
                    Console.WriteLine("Para Gecersiz");
                }
                Console.WriteLine("Bakiyeniz: " + this.getTotalCoin());
 
                isSelected = SelectionScreenSub();
            }
        }

        public bool SelectionScreenSub()
        {
            string cikis;
            Console.WriteLine("Secim Ekranina Gitmek icin Y - Para Eklemek Icin N ye basiniz");
            cikis = Console.ReadLine();
            if (cikis == "y" || cikis == "Y")
            {
                return false;
            }
            else if (cikis == "n" || cikis == "N")
            {
                return true;
            }
            else
            {
                SelectionScreenSub();
                return true;
            }
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
