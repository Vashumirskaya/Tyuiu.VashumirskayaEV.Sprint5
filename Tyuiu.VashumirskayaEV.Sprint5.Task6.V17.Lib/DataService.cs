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

            int sequenceCount = 0;
            bool inSpaceSequence = false;
            int spaceSequenceLength = 0;

            foreach (char c in fileContent)
            {
                if (c == ' ')
                {
                    spaceSequenceLength++;
                    inSpaceSequence = true;
                }
                else
                {
                    if (inSpaceSequence)
                    {
                        if (spaceSequenceLength >= 2)
                        {
                            sequenceCount++;
                        }

                        spaceSequenceLength = 0;
                        inSpaceSequence = false;
                    }
                }
            }

            if (inSpaceSequence && spaceSequenceLength >= 2)
            {
                sequenceCount++;
            }

            return sequenceCount;
        }
    }
}
