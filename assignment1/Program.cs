using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface userInterface = new UserInterface(); //Creates a new UI instance

            WineItem[] wineItems = new WineItem[50000]; // Creates a new array of WineItems

            CSVProcessor ProcessList = new CSVProcessor();  //Exactly what it says on the tin, processes the included CSV                                 

            userInterface.MainMenu(wineItems,ProcessList);

            Environment.Exit(0);







        }
    }
}
