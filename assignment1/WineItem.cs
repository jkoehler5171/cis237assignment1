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

        public int GetArrayLength(WineItem[] wineItems) //Calculates the number of items in the array for use elsewhere. Pretty much exactly what it says on the tin.
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
