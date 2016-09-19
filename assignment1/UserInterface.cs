using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {

        public void MainMenu()
        {
            bool exitBoolean = true;
            int choiceInt;
             
            while(exitBoolean != false)
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
                            //Placeholder
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            exitBoolean = true;
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("Please enter a valid option");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid option");
                }



                    }
                }
            }

        }



