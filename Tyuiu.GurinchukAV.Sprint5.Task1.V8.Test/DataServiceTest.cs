using System.IO;
using Tyuiu.GurinchukAV.Sprint5.Task1.V8.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\настя\source\repos\Tyuiu.GurinchukAV.Sprint5\Tyuiu.GurinchukAV.Sprint5.Task1.V8\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
