using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            Regex regex = new Regex(@"\s{2,}");

            MatchCollection matches = regex.Matches(fileContent);

            int totalSpaces = 0;
            foreach (Match match in matches)
            {
                totalSpaces += match.Length;
            }

            return totalSpaces;
        }
    }
}
