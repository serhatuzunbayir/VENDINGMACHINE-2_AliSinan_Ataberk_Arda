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

            Console.WriteLine("--- Add a Coin --- Only 25 - 50 - 100");
            while (true)
            {
                int coin;
                string cikis;
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
                Console.Write("Cikis icin 0 a basiniz");
                cikis = Console.ReadLine();
                if (cikis == "0")
                {
                    break;
                }

            }
            
            nukaVendingMachine.DisplayDrinkSelectionMenu();

            //Stop
            Console.WriteLine("Press a key to Exit.");
            Console.ReadLine();
        }
    }
}
