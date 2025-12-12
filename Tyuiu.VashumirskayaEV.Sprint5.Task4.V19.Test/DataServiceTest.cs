using Tyuiu.VashumirskayaEV.Sprint5.Task4.V19.Lib;
using System.IO;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, (Math.PI / 2).ToString(System.Globalization.CultureInfo.InvariantCulture));

            try
            {
                Assert.ThrowsException<ArgumentException>(() =>
                    ds.LoadFromDataFile(tempPath));
            }
            finally
            {
                File.Delete(tempPath);
            }
        }
    }
}
