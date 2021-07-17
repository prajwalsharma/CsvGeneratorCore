using System;
using CsvHelper;
using System.IO;
using System.Globalization;

namespace CsvGeneratorCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Fetch data
            var employees = EmployeeRepository.GetEmployees();

            // 2. Set path to store csv files
            string pathToSaveFiles = $"D:\\Programming\\.NET Standard\\CsvGeneratorCore\\CsvFiles\\employees.csv";

            // 3. Generate CSV file
            using (var writer = new StreamWriter(pathToSaveFiles))
            {
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(employees);
                }
            }
        }
    }
}
