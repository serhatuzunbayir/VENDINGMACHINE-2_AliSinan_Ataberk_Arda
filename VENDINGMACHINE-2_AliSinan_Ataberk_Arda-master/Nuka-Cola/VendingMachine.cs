﻿using System;
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

        // Create cola objects
        NukaCola icenuka = new IceNuka();
        NukaCola quantumnuka = new QuantumNuka();
        NukaCola cartcurt = new Cartcurt();


        // Get balance
        public int getTotalCoin()
        {
            return totalCoin;
        } 

        // Add coin to balance
        public void addCoin(int coin)
        {
            totalCoin += coin;
        }


         // Show what user can select with price
        public void DisplayDrinkSelectionMenu()
        {
            int selection;

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------         1 -> Ice Cold Nuka Cola  (200)      ---------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------         2 -> Quantum Nuka Cola  (300)      ----------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("---------         3 -> Cart Curt Nuka Cola  (50)      ---------");
            Console.WriteLine("---------------------------------------------------------------");
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


        //Check for discount coupon and make discount before charge
        public float Discount(float actualPrice)
        {
            float newPrice = 0;
            Console.WriteLine("Do you have >>Summer Sale<< discount coupon? Y/N ");
            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var yesOrNo = readLine.ToString();

                if (yesOrNo == "y" || yesOrNo == "yes")
                {
                    newPrice = CalculateDiscount(actualPrice);
                }
                else
                {
                    newPrice = actualPrice;
                }
            }

            return newPrice;
        }

        //helper function to calculate discount
        public float CalculateDiscount(float colaPrice)
        {
            colaPrice = colaPrice * 0.75f; // %25 discount
            return colaPrice;
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
                    Console.WriteLine("Put coin to the machine..");
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
                    Console.WriteLine("Error: Invalid or fake money.");
                }

                Console.WriteLine("Balance: " + getTotalCoin());
                Console.WriteLine("To select a Nuka Cola enter Y or Add money");
                exit = Console.ReadLine();
            }

            putCoinTheMachine(-1);

            // Add coin exit statement
            while (isSelected)
            {  
                if (exit == "y" || exit == "Y" || exit == null)
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

        // Shows what user selected and change 
        public void Selection(int selection)
        {
            
            switch (selection)
            {
                case 1:
                    icenuka.setPrice((int)Discount(icenuka.getPrice())); //Ask for discount coupon and make discount
                    Console.WriteLine("Great selection! Your brain will freeze..." + icenuka.getName());
                    if (totalCoin < icenuka.getPrice())
                    {
                        Console.WriteLine("But you need put more coin!"); //notify user
                        SelectionScreen(); // show UI again
                    }
                    else
                    {
                        totalCoin -= icenuka.getPrice();
                        Console.WriteLine("Change: " + totalCoin);
                    }
                    break;
                case 2:
                    quantumnuka.setPrice((int)Discount(quantumnuka.getPrice()));  //Ask for discount coupon and make discount
                    Console.WriteLine("Great selection! You will fly..." + quantumnuka.getName());
                    if (totalCoin < quantumnuka.getPrice())
                    {
                        Console.WriteLine("But you need put more coin!");
                        SelectionScreen();
                    }
                    else
                    {
                        totalCoin -= quantumnuka.getPrice();
                        Console.WriteLine("Change: " + totalCoin);
                    }
                    break;
                case 3:
                    cartcurt.setPrice((int)Discount(cartcurt.getPrice()));  //Ask for discount coupon and make discount
                    Console.WriteLine("Great selection! You will like it." + cartcurt.getName());
                    if (totalCoin < cartcurt.getPrice())
                    {
                        Console.WriteLine("But you need put more coin!");
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
