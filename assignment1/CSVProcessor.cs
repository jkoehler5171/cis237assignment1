using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        string _csvPath = "../../../datafiles/WineList.csv";

        WineItemCollection[] wineCollection = new WineItemCollection[500];
        

        public bool ProcessCSV()
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(_csvPath);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    LoadArray(line, wineCollection, counter++);
                }

                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }

        }

        static void LoadArray(string line, WineItemCollection[] wineCollection, int counter)
        {
            string[] lineInfo = line.Split(',');

            string wineID = lineInfo[0];
            string wineDescription = lineInfo[1];
            string winePack = lineInfo[2];

            wineCollection[counter]= new WineItem(wineID, wineDescription, winePack);


        }

    }
}
