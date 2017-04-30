using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    class Program
    {
        // Main
        static void Main(string[] args)
        {
            // Creates Vending Machine Object
            var nukaVendingMachine = new VendingMachine();

            // Gives info to users at start
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---Welcome to Nuka-Cola Corparation Vending Machine---");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("1 -> Ice Cold Nuka Cola   (Price:200)");           
            Console.WriteLine("2 -> Quantum Nuka Cola    (Price:300)");           
            Console.WriteLine("3 -> Cart Curt Nuka Cola  (Price:50)");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");

            // Calls selection screen
            nukaVendingMachine.SelectionScreen();
            // Calls display drink selection menu
            nukaVendingMachine.DisplayDrinkSelectionMenu();

            //Stop
            Console.WriteLine("Press a key to Exit.");
            Console.ReadLine();
        }
    }
}
