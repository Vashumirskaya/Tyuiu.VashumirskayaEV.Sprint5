using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib
{
    public class DataService : ISprint5Task1V27
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string dir = Path.GetTempPath();
            string path = Path.Combine(dir, "OutPutFileTask0.txt");

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(Math.Sin(x), 2);
                strY = Convert.ToString(y);

                if (x == stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
