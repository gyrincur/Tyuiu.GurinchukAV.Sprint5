using Tyuiu.GurinchukAV.Sprint5.Task1.V8.Lib;
namespace Tyuiu.GurinchukAV.Sprint5.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Гуринчук А. В. | ИБКСб 25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:  Класс File. Запись набора данных в текстовый файл                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Гуринчук Анастасия Витальевна | ИБКСб 25-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 3                        *");
            Console.WriteLine("* результат сохранить в текстовый файл и вывести на консоль.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            string resultFromFile = File.ReadAllText(res);

            Console.WriteLine("Результат:" + resultFromFile);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
