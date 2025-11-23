using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GurinchukAV.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim().Replace(".", ",");
                    string[] numbers = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string numberStr in numbers)
                    {
                        if (double.TryParse(numberStr, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                        {
                            if (num == Math.Truncate(num)) 
                            {
                                int integerNum = (int)num;
                                return CalculateFactorial(integerNum);
                            }
                        }
                    }
                }
            }

            return 0;
        }

        private double CalculateFactorial(int n)
        {
            if (n < 0) return 0;
            if (n == 0 || n == 1) return 1;

            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return Math.Round(result, 3); 
        }
    }
}