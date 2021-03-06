﻿//Jordan Koehler, CIS237 TR@ 3:30
//September 21st 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        private bool listProcessed = false;
        
        public UserInterface()
        {

        }

        public UserInterface(WineItem[] wineItems, CSVProcessor processList)
        {

        }

        public void MainMenu(WineItem[] wineItems, CSVProcessor processList) // Contains the main menu text and decsion structure. 
        {
            bool exitBoolean = false;
            int choiceInt;

            while (exitBoolean == false)
            {
                Console.WriteLine("Wine List Program V1");
                Console.WriteLine();
                Console.WriteLine("Please choose a menu option below:");
                Console.WriteLine("1. Load Wine List");
                Console.WriteLine("2. Display Wine List");
                Console.WriteLine("3. Search Wine List");
                Console.WriteLine("4. Add Item To Wine List");
                Console.WriteLine("5. Exit Program");
                Console.WriteLine();
                Console.Write("Enter the number of your choice: ");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:
                            if (listProcessed == false)
                            {
                                processList.ProcessCSV(wineItems);
                                listProcessed = true;
                                Console.WriteLine("List successfully loaded");
                            }
                            else
                            {
                                Console.WriteLine("The list has already been loaded.");
                            }
                            break;
                        case 2:
                            PrintList(wineItems);
                            break;
                        case 3:
                            SearchArray(wineItems);
                            break;
                        case 4:
                            WineItem.InsertToArray(wineItems);
                            break;
                        case 5:
                            exitBoolean = true;
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid option");

                }




            }

            

        }

        private void PrintList(WineItem[] wineItems) // Prints out the wine list loaded into the array. Exactly what it says on the tin.
        {
            int counter = 0;

            while (wineItems[counter] != null)
            {
                Console.WriteLine(wineItems[counter].ToString());
                counter++;
            }



        }

        private void SearchArray(WineItem[] wineItems) // Searches the array for a matching Wine ID. Simple linear search
        {
            string searchTarget;
            int subscript = 0;
            int countInt = 0;

            Console.WriteLine();

            Console.Write("Please enter the wine ID: ");

            searchTarget = Console.ReadLine().Trim();

            Console.WriteLine();

            while (wineItems[subscript] != null)
            {
                if (wineItems[subscript].WineID == searchTarget)
                {
                    Console.WriteLine("Item Found!");
                    Console.WriteLine(wineItems[subscript].ToString());
                    Console.WriteLine("");

                    countInt++;
                }
                subscript++;

            }

            if (countInt < 1)
            {
                Console.WriteLine("Item not found");
                Console.WriteLine("");
            }



        }
                        
    }

}



