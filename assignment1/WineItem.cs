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

        public override string ToString()
        {
            return _wineID + " " + _wineDescription + " " + _winePack;

        }

    }
}
