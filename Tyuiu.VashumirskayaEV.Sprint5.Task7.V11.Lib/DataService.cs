using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task7.V11.Lib
{
    public class DataService : ISprint5Task7V11
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string result = "";

            for (int i = 0; i < content.Length; i++)
            {
                char c = content[i];

                if ((c >= 'а' && c <= 'я') || c == 'ё')
                {
                    continue;
                }

                result += c;
            }

            string dir = Path.GetTempPath();
            string outPath = Path.Combine(dir, "OutPutDataFileTask7V11.txt");

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
