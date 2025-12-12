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

            string nonExistentPath = @"C:\NonExistentFolder\nonexistent.txt";

            Assert.ThrowsException<FileNotFoundException>(() =>
                ds.LoadFromDataFile(nonExistentPath));
        }
    }
}
