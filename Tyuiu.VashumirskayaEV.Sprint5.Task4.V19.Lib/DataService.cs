using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            double x = double.Parse(strX, CultureInfo.InvariantCulture);

            double cosX = Math.Cos(x);

            if (Math.Abs(cosX) < 1e-12) 
            {
                throw new ArgumentException($"Деление на ноль! cos({x}) = 0");
            }

            double y = Math.Pow(x / cosX, 2);

            y = Math.Round(y, 3);

            return y;
        }
    }
}
