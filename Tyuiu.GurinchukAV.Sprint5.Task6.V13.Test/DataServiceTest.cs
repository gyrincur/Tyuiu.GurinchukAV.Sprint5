using System.IO;
using Tyuiu.GurinchukAV.Sprint5.Task6.V13.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCale()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\Sprint5Task6\Sprint5Task6\InPutDataFileTask6V13.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);

        }

        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\Sprint5Task6\Sprint5Task6\InPutDataFileTask6V13.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExsists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsists);
        }
    }
}