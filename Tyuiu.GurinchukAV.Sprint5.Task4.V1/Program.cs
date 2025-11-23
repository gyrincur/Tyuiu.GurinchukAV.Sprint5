using Tyuiu.GurinchukAV.Sprint5.Task4.V1.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гуринчук А. В. | ИБКСб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение.                         *");
            Console.WriteLine("* Прочитать значение из файла и подставить в формулу                      *");
            Console.WriteLine("* y = 1/(cos(x)+x) - 4.12x                                                *");
            Console.WriteLine("* Вычислить значение и вернуть результат на консоль.                      *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\Sprint5Task4\Sprint5Task4\InPutDataFileTask4V1.txt";
            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);

            Console.WriteLine("Результат вычисления: " + result);
            Console.ReadKey();
        }
    }
}