﻿//Jordan Koehler, CIS237 TR@ 3:30
//September 21st 2016

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
       string _csvPath = "../../../datafiles/WineList.csv";  //This holds the location of the CSV file

        


        public bool ProcessCSV(WineItem[] wineItems) //Reads the CSV file using a Streamreader
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(_csvPath);

                int counter = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    LoadArray(line, wineItems, counter++);
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

        static void LoadArray(string line, WineItem[] wineItems, int counter) // Loads the CSV information into the Array.
        {
            string[] lineInfo = line.Split(',');

            string wineID = lineInfo[0];
            string wineDescription = lineInfo[1];
            string winePack = lineInfo[2];

            wineItems[counter]= new WineItem(wineID, wineDescription, winePack);


        }

    }
}
