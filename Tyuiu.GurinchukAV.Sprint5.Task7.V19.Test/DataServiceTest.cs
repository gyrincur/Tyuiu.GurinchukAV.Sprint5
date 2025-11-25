using System.IO;
using Tyuiu.GurinchukAV.Sprint5.Task7.V19.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\Sprint5Task7\Sprint5Task7\InPutDataFileTask7V19.txt";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}
