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
            string path = @"C:\Users\huawei\source\repos\Tyuiu.VashumirskayaEV.Sprint5\Tyuiu.VashumirskayaEV.Sprint5.Task0.V8\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
