using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GurinchukAV.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V19.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            string result = System.Text.RegularExpressions.Regex.Replace(content,"сс","",System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            File.WriteAllText(pathSaveFile, result);
            return pathSaveFile;
        }
    }
}
