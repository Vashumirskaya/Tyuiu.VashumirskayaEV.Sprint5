using Tyuiu.VashumirskayaEV.Sprint5.Task5.V13.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "10 20 30 40");

            try
            {
                double result = ds.LoadFromDataFile(tempPath);
                Assert.AreEqual(0, result);
            }
            finally
            {
                File.Delete(tempPath);
            }
        }
    }
}
