using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GurinchukAV.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lowerLine = line.ToLower();
                    for (int i = 0; i < lowerLine.Length - 1; i++)
                    {
                        if (lowerLine[i] == 'с' && lowerLine[i + 1] == 'с')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
