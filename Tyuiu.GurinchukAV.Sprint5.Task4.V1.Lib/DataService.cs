using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.GurinchukAV.Sprint5.Task4.V1.Lib
{
    public class DataService : ISprint5Task4V1
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, System.Globalization.CultureInfo.InvariantCulture);
            double res = (1 / (Math.Cos(x) + x)) - (4.12 * x);
            return Math.Round(res, 3);
        }
    }
}
