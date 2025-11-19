using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GurinchukAV.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
               
                if (x == 1)
                {
                    y = 0.0; 
                }
                else
                {
                    double numerator = 2.0 + Math.Cos(x);
                    double denominator = 2.0 * x - 2.0;
                    y = 4.0 - 2.0 * x + numerator / denominator;
                }
                y = Math.Round(y, 2);

                strY = y.ToString("F2");
                if (x < stopValue) 
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
