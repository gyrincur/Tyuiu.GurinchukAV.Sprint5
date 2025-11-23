using Tyuiu.GurinchukAV.Sprint5.Task5.V7.Lib;
using System.IO;
namespace Tyuiu.GurinchukAV.Sprint5.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\Sprint5Task5\Sprint5Task5\InPutDataFileTask5V7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}
