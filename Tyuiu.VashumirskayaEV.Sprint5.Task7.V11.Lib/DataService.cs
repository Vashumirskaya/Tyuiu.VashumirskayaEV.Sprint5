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

            string textWithoutSpaces = "";
            foreach (char c in content)
            {
                if (c != ' ')
                {
                    textWithoutSpaces += c;
                }
            }

            string result = "";
            foreach (char c in textWithoutSpaces)
            {
                bool isLowerRussian =
                    (c >= 'а' && c <= 'я') || c == 'ё';

                if (!isLowerRussian)
                {
                    result += c;
                }
            }

            string directory = Path.GetDirectoryName(path);
            string outPath = Path.Combine(directory, "OutPutDataFileTask7V11.txt");

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
