using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double result = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);

            result = Math.Round(result, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}
