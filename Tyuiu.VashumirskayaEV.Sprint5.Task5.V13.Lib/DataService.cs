using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            string[] numberStrings = fileContent.Split(new char[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string numStr in numberStrings)
            {
                if (double.TryParse(numStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (number >= -1.5 && number <= 1.5)
                    {
                        sum += number;
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                return 0;
            }

            double average = sum / count;

            average = Math.Round(average, 3);

            return average;
        }
    }
}
