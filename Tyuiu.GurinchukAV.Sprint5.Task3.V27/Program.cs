using Tyuiu.GurinchukAV.Sprint5.Task3.V27.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гуринчук А. В. | ИБКС6 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКС6 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3                         *");
            Console.WriteLine("* результат сохранить в бинарный файл и вывести на консоль                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            double fileValue;
            using (BinaryReader reader = new BinaryReader(File.Open(res, FileMode.Open)))
            {
                fileValue = reader.ReadDouble();
            }

            Console.WriteLine("Результат: " + fileValue.ToString("F3"));
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}