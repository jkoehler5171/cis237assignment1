using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

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
                            processList.ProcessCSV(wineItems);
                            break;
                        case 2:
                            PrintList(wineItems);
                            break;
                        case 3:
                            SearchArray(wineItems);
                            break;
                        case 4:
                            InsertToArray(wineItems);
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
        
        
        private void InsertToArray(WineItem[] wineItems) // Adds an item to the end of the array. Does not save to the CSV
        {
            string userAddedID;
            string userAddedDescription;
            string userAddedPack;
            int arrayLength;

            Console.WriteLine("");
            Console.WriteLine("Please enter a new wine ID:");
            userAddedID = Console.ReadLine().Trim();

            Console.WriteLine("");
            Console.WriteLine("Please enter a new wine description:");
            userAddedDescription = Console.ReadLine().Trim();

            Console.WriteLine("");
            Console.WriteLine("Please enter the packaging information:");
            userAddedPack = Console.ReadLine().Trim();

            Console.WriteLine("");
            Console.WriteLine("The following item will be added to the wine list:");
            Console.WriteLine(userAddedID + " " + userAddedDescription + " " + userAddedPack);
            Console.WriteLine("");

            arrayLength = GetArrayLength(wineItems);

            wineItems[arrayLength] = new WineItem(userAddedID, userAddedDescription, userAddedPack); 



        }

        private int GetArrayLength(WineItem[] wineItems) //Calculates the number of items in the array
        {
            int arrayLength = 0;

            while (wineItems[arrayLength] != null)
            {
                arrayLength++;
            }

            return arrayLength;
        }




    }

}



