using System.IO;
using Tyuiu.VashumirskayaEV.Sprint5.Task0.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task0.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 3;
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path), "Файл не создан");

            double expected = Math.Round((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)), 3);
            string text = File.ReadAllText(path);

            Assert.AreEqual(expected.ToString(), text);
        }
    }
}
