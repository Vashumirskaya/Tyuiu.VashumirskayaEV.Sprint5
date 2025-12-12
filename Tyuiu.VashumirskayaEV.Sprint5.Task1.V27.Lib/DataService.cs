using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Табулирование функции F(x) = (3x - 1.5)/(sin(x) - 3 + x) + 2");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}] с шагом 1");
                writer.WriteLine("=================================================");
                writer.WriteLine("|   x   |   F(x)   |");
                writer.WriteLine("=================================================");

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

                    writer.WriteLine($"| {x,5} | {value,8:F2} |");
                }

                writer.WriteLine("=================================================");
            }

            return path;
        }
    }
}
