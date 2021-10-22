using System;

namespace Day20_CSV_HelperAndJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine("# Read data from CSV & Write data in CSV");
            //CSVHandler.ImplementCSVDataHandling();
            ReadCSV_And_WriteJSON.ImplementCSVToJSON();

            Console.ReadKey();
        }
    }
}
