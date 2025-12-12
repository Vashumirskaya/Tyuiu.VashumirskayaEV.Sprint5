using Tyuiu.VashumirskayaEV.Sprint5.Task3.V26.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;

            string path = ds.SaveToFileTextData(x);

            double resultFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                resultFromFile = reader.ReadDouble();
            }

            string resultString = resultFromFile.ToString("F3");
            Assert.AreEqual("11.680", resultString);

            File.Delete(path);
        }
    }
}
