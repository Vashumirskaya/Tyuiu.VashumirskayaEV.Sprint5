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

            string noSpaces = "";
            foreach (char c in content)
            {
                if (c != ' ' && c != '\t')
                {
                    noSpaces += c;
                }
            }

            string result = "";
            foreach (char c in noSpaces)
            {
                bool isLowerRu = (c >= 'а' && c <= 'я') || c == 'ё';
                if (!isLowerRu)
                {
                    result += c;
                }
            }

            string dir = Path.GetTempPath();
            string outPath = Path.Combine(dir, "OutPutDataFileTask7V11.txt");

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
