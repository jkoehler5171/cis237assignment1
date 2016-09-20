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

        public UserInterface(WineItem[] wineItems)
        {

        }

        public void MainMenu(WineItem[] wineItems)
        {
            bool exitBoolean = false;
            int choiceInt;

            while (exitBoolean == false)
            {
                Console.WriteLine("Wine List Program V1");
                Console.WriteLine();
                Console.WriteLine("Please choose a menu option below:");
                Console.WriteLine("1. Display Wine List");
                Console.WriteLine("2. Search Wine List");
                Console.WriteLine("3. Add Item To Wine List");
                Console.WriteLine("4. Exit Program");
                Console.WriteLine();
                Console.Write("Enter the number of your choice: ");

                try
                {
                    choiceInt = Convert.ToInt32(Console.ReadLine());

                    switch (choiceInt)
                    {
                        case 1:
                            PrintList(wineItems);
                            break;
                        case 2:
                            SearchArray(wineItems);
                            break;
                        case 3:
                            InsertToArray(wineItems);
                            break;
                        case 4:
                            exitBoolean = true;
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid option");

                    Console.WriteLine(e.ToString());
                    Console.WriteLine();
                    Console.WriteLine(e.StackTrace);

                }




            }

            Environment.Exit(0);

        }

        private void PrintList(WineItem[] wineItems)
        {
            int counter = 0;

            while (wineItems[counter] != null)
            {
                Console.WriteLine(wineItems[counter].ToString());
                counter++;
            }



        }

        private void SearchArray(WineItem[] wineItems)
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
        
        
        private void InsertToArray(WineItem[] wineItems)
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

            wineItems[arrayLength + 1] = new WineItem(userAddedID, userAddedDescription, userAddedPack); 



        }

        private int GetArrayLength(WineItem[] wineItems)
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



