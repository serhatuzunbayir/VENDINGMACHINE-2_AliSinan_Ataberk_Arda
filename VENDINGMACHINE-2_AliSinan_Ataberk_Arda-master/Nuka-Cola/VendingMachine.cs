using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    // Class that creates vending machine
   public class VendingMachine
    {
        public Boolean instanceVendingMachine = true;
        private int totalCoin;

        // Creates cola objects
        NukaCola icenuka = new IceNuka();
        NukaCola quantumnuka = new QuantumNuka();
        NukaCola cartcurt = new Cartcurt();


        // Gets balance
        public int getTotalCoin()
        {
            return totalCoin;
        } 

        // Adds coin to balance
        public void addCoin(int coin)
        {
            totalCoin += coin;
        }


         // Shows what user can select with price
        public void DisplayDrinkSelectionMenu()
        {
            int selection;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------         1 -> Ice Cold Nuka Cola  (200)      ---------");
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
                Console.WriteLine("Error invalid selection, please select again");
                this.DisplayDrinkSelectionMenu();
            }

            Selection(selection);

        }

        // Ask user to add money or select a product
        public void SelectionScreen()
        {   
            Console.WriteLine("--- Add a Coin --- Only 25 - 50 - 100");
            bool isSelected = true;
            int coin;
            string exit;
            void putCoinTheMachine(int money)
                {
                if(money == -1)
                {
                    Console.WriteLine("Put money to the machine..");
                coin = Convert.ToInt32(Console.ReadLine());             
                }
                else
                {
                    coin = money;
                }
              
                if (coin == 25 || coin == 50 || coin == 100)
                {
                    this.addCoin(coin);
                }
                else
                {
                    Console.WriteLine("Error: Invalid money.");
                }

                Console.WriteLine("Balance: " + this.getTotalCoin());
                Console.WriteLine("Select cola for enter Y or Add money");
                exit = Console.ReadLine();
            }

            putCoinTheMachine(-1);

            while (isSelected)
            {  
                
 
            
            if (exit == "y" || exit == "Y")
            {
                isSelected = false;
            }
            else if(IsNumeric(exit))
            {
                 isSelected = true;
                 int money = Convert.ToInt32(exit);
                 exit = null;
                 putCoinTheMachine(money);
            }
            else
            {
                Console.WriteLine("You pick the wrong choice");
                putCoinTheMachine(-1);
                isSelected = true;
            }
            }
        }

        // Shows what users selected and change 
        public void Selection(int selection)
        {
            switch (selection)
            {
                case 1:
                    Console.WriteLine("Great selection! " + icenuka.getName());
                    if (totalCoin < icenuka.getPrice())
                    {
                        Console.WriteLine("But you need more money!");
                        SelectionScreen();
                    }
                    else
                    {
                        totalCoin -= icenuka.getPrice();
                        Console.WriteLine("Change: " + totalCoin);
                    }
                    break;
                case 2:
                    Console.WriteLine("Great selection! " + quantumnuka.getName());
                    if (totalCoin < quantumnuka.getPrice())
                    {
                        Console.WriteLine("But you need more money!");
                        SelectionScreen();
                    }
                    else
                    {
                        totalCoin -= quantumnuka.getPrice();
                        Console.WriteLine("Change: " + totalCoin);
                    }
                    break;
                case 3:
                    Console.WriteLine("Great selection! " + cartcurt.getName());
                    if (totalCoin < cartcurt.getPrice())
                    {
                        Console.WriteLine("But you need more money!");
                        SelectionScreen();
                    }
                    else
                    {
                        totalCoin -= cartcurt.getPrice();
                        Console.WriteLine("Change: " + totalCoin);
                    }
                    break;

            }
        }

        public static bool IsNumeric(string value)
        {
        double oReturn = 0;
        return double.TryParse(value, out oReturn);
        }
        
    } //end of VendingMachine class
}
