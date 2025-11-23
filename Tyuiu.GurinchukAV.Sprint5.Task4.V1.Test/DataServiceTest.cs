using Tyuiu.GurinchukAV.Sprint5.Task4.V1.Lib;
using System.IO;
namespace Tyuiu.GurinchukAV.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string path = @"C:\DataSprint5\Sprint5Task4\Sprint5Task4\InPutDataFileTask4V1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            File.Delete(path);
        }
    }
}