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
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(path));
            File.Delete(path);
        }
    }
}
