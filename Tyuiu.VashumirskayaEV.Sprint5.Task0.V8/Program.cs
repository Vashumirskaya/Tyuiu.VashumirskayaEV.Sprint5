using Tyuiu.VashumirskayaEV.Sprint5.Task0.V8.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task0.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Вычислить y = (x^3 - 1) / (4x^2) при x = 3, округлить до 3 знаков и     *");
            Console.WriteLine("* сохранить результат в файл OutPutFileTask0.txt.                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: "  + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
