using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task0.V8.Lib
{
    public class DataService : ISprint5Task0V8
    {
        public string SaveToFileTextData(int x)
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask0.txt");

            double y = (Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2));
            y = Math.Round(y, 3);

            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
