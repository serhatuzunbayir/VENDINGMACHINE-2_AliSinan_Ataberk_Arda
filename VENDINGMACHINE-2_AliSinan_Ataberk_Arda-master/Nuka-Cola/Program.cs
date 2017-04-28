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
            Console.WriteLine("");
            Console.WriteLine("1 -> Ice Cold Nuka Cola   (Price:200)");           
            Console.WriteLine("2 -> Quantum Nuka Cola    (Price:300)");           
            Console.WriteLine("3 -> Cart Curt Nuka Cola  (Price:50)");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------------");

            nukaVendingMachine.SelectionScreen();
            nukaVendingMachine.DisplayDrinkSelectionMenu();

            //Stop
            Console.WriteLine("Press a key to Exit.");
            Console.ReadLine();
        }
    }
}
