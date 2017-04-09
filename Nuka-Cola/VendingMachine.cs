using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Nuka_Cola
{
    class VendingMachine
    {
        private const int CostOfDrink = 175;

        public int RunningTotal { get; set; }

        public VendingMachine()
        {
            RunningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            switch (money)
            {
                case 25:
                    RunningTotal += 25;
                    break;
                case 50:
                    RunningTotal += 50;
                    break;
                case 100:
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid or fake money dedected!");
                    break;
            }
        }

        public void DisplayDrinkSelectionMenu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------         1 -> Nuka-Cola  (175)      ---------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Please select a drink: ");
            MakeDrinkSelection(Convert.ToInt32(Console.ReadLine()));
        }

        private void MakeDrinkSelection(int selection)
        {
            bool isSelected = false;
            while (!isSelected)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Nuka-Cola is coming. Nice choice!");
                        isSelected = true;
                        ReturnChange();
                        break;
                    default:
                        Console.WriteLine("We dont have that one. Try another Cola. Dont be shy!");
                        selection = Convert.ToInt32(Console.ReadLine());
                        isSelected = false;
                        break;
                }
            }
        }

        private void ReturnChange()
        {
            if (RunningTotal > CostOfDrink)
            {
                Console.WriteLine("Your change is {0:C}", RunningTotal - CostOfDrink);
            }
        }

        public bool CheckTotal()
        {
            if (RunningTotal >= CostOfDrink)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
