//Jordan Koehler, CIS237 TR@ 3:30
//September 21st 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {

        private string _wineID;
        private string _wineDescription;
        private string _winePack;


        public string WineID
        {
            get { return _wineID; }
            set { _wineID = value; }
        }

        public string WineDescription
        {
            get { return _wineDescription; }
            set { _wineDescription = value;}
        }

        public string WinePack
        {
            get { return _winePack; }
            set { _winePack = value; }
        }    
        

        public WineItem(string wineID, string wineDescription, string winePack)
        {
            _wineID = wineID;
            _wineDescription = wineDescription;
            _winePack = winePack;
        }

        public WineItem()
        {

        }

        public override string ToString() // Overwrites the default ToString Method. Prints the ID, Description, and Packaging information.
        {
            return _wineID + " " + _wineDescription + " " + _winePack;

        }

        public static int GetArrayLength(WineItem[] wineItems) //Calculates the number of items in the array for use elsewhere. Pretty much exactly what it says on the tin.
        {
            int arrayLength = 0;

            while (wineItems[arrayLength] != null)
            {
                arrayLength++;
            }

            return arrayLength;
        }

        public static void InsertToArray(WineItem[] wineItems) // Adds an item to the end of the array. Does not save to the CSV
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

            arrayLength = WineItem.GetArrayLength(wineItems);

            wineItems[arrayLength] = new WineItem(userAddedID, userAddedDescription, userAddedPack);



        }

    }
}
