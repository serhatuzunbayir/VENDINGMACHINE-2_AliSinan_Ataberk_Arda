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

            while (!nukaVendingMachine.CheckTotal())
            {
                Console.WriteLine("Please enter coin(25, 50 or 100)");
                nukaVendingMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            nukaVendingMachine.DisplayDrinkSelectionMenu();

            //Stop
            Console.WriteLine("Press a key to Exit.");
            Console.ReadLine();
        }
    }
}
