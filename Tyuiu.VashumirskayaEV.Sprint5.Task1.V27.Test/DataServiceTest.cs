using Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = 1;
            int stopValue = 5;
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path), "Файл не создан");

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(5, lines.Length, "Не все строки записаны в файл");

            Assert.AreEqual("0.84", lines[0], "Некорректное значение для x=1");
            Assert.AreEqual("0.91", lines[1], "Некорректное значение для x=2");
            Assert.AreEqual("0.14", lines[2], "Некорректное значение для x=3");
            Assert.AreEqual("0.84", lines[3], "Некорректное значение для x=4");
            Assert.AreEqual("0.91", lines[4], "Некорректное значение для x=5");
        }
    }
}
