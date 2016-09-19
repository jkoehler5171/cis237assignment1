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

            WineItem[] wineItems = new WineItem[500];

            CSVProcessor ProcessList = new CSVProcessor();

            ProcessList.ProcessCSV(wineItems);

            UserInterface userInterface = new UserInterface();

            userInterface.MainMenu(wineItems);

            

                      

            

        }
    }
}
