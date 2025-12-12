using Tyuiu.VashumirskayaEV.Sprint5.Task6.V17.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, "Это  пример  строки с лишними пробелами.");

            try
            {
                int result = ds.LoadFromDataFile(tempPath);
                int expected = 2;
                Assert.AreEqual(expected, result);
            }
            finally
            {
                File.Delete(tempPath);
            }
        }
    }
}
