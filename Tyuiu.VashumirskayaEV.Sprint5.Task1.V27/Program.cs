using Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = 1;  // Начальное значение
            int stopValue = 5;   // Конечное значение

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить значение функции f(x) = sin(x) для значений x от {0} до {1}, *", startValue, stopValue);
            Console.WriteLine("* округлить результаты до 2 знаков после запятой и сохранить в файл.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"startValue = {startValue}, stopValue = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
