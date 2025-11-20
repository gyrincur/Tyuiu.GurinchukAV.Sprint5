using System.IO;
using Tyuiu.GurinchukAV.Sprint5.Task3.V27.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\настя\source\repos\Tyuiu.GurinchukAV.Sprint5\Tyuiu.GurinchukAV.Sprint5.Task3.V27\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
