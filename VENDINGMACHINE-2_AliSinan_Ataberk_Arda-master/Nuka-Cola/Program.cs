using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var nukaVendingMachine = new VendingMachine();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---Welcome to Nuka-Cola Corparation Vending Machine---");
            Console.WriteLine("------------------------------------------------------");

            /*Console.WriteLine("--- Add a Coin --- Only 25 - 50 - 100");
            bool isSelected = true;
            while (isSelected)
            {
                int coin;
                string cikis;
                Console.WriteLine("Para atmaniz bekleniyor");
                coin = Convert.ToInt32(Console.ReadLine());
                if (coin == 25 || coin == 50 || coin == 100)
                {
                    nukaVendingMachine.addCoin(coin);
                }
                else
                {
                    Console.WriteLine("Para Gecersiz");
                }
               Console.WriteLine("Bakiyeniz: " + nukaVendingMachine.getTotalCoin());
               Console.WriteLine("Secim Ekranina Gitmek icin Y - Para Eklemek Icin N ye basiniz");
                cikis = Console.ReadLine();
                if (cikis == "y" || cikis == "Y")
                {
                    isSelected = false;
                    break;
                }
                else if(cikis == "n" || cikis == "N")
                {

                }
                else
                {
                    Console.WriteLine("Hatali Giris Yaptiniz...");
                }

            }*/

            nukaVendingMachine.SelectionScreen();
            nukaVendingMachine.DisplayDrinkSelectionMenu();

            //Stop
            Console.WriteLine("Press a key to Exit.");
            Console.ReadLine();
        }
    }
}
