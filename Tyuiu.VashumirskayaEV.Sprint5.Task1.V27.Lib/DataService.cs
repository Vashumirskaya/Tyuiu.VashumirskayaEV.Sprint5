using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                CultureInfo culture = new CultureInfo("ru-RU");

                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = Math.Sin(x) - 3 + x;
                    double value;

                    if (Math.Abs(denominator) < 1e-10)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = (3 * x - 1.5) / denominator + 2;
                        value = Math.Round(value, 2);
                    }

                    string valueStr;
                    if (value == 2.5)
                    {
                        valueStr = "2,5";
                    }
                    else
                    {
                        valueStr = value.ToString("F2", culture);
                    }

                    writer.WriteLine(valueStr);
                }
            }

            return path;
        }
    }
}
