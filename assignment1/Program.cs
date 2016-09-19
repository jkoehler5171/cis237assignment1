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

            WineItem[] wineCollection = new WineItem[500];

            CSVProcessor ProcessList = new CSVProcessor();

            ProcessList.ProcessCSV(wineCollection);

            Console.WriteLine(wineCollection[3].ToString());

                      

            

        }
    }
}
