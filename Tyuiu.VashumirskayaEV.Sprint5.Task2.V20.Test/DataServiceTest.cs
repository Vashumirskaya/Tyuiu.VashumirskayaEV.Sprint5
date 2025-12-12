using Tyuiu.VashumirskayaEV.Sprint5.Task2.V20.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[1, 1] { { 0 } };

            string path = ds.SaveToFileTextData(matrix);
            string result = File.ReadAllText(path).Trim();

            Assert.AreEqual("0", result);

            File.Delete(path);
        }
    }
}
