using Tyuiu.VashumirskayaEV.Sprint5.Task4.V19.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task4.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: [ВашаФамилия] [ВашеИмя] | Вариант #19";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: [ВашаФамилия] [ВашеИмя] | [ВашаГруппа]                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с вещественным значением.                                      *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо X в формуле.            *");
            Console.WriteLine("* Формула: y = (x / cos(x))^2                                            *");
            Console.WriteLine("* Вычислить значение и вернуть полученный результат на консоль.          *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";

            Console.WriteLine($"* Файл с данными: {path}                        *");

            if (!File.Exists(path))
            {
                Console.WriteLine("* Файл не найден! Создайте папку C:\\DataSprint5\\ и скопируйте туда файл. *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                string xValue = File.ReadAllText(path).Trim();
                Console.WriteLine($"* Значение X из файла: {xValue}                                       *");
                Console.WriteLine($"* Формула: y = (x / cos(x))^2                                         *");
                Console.WriteLine($"* Результат (округлено до 3 знаков): {result:F3}                     *");

                double x = Convert.ToDouble(xValue);
                double cosX = Math.Cos(x);
                Console.WriteLine($"* cos({x:F3}) = {cosX:F3}                                            *");
                Console.WriteLine($"* {x:F3} / {cosX:F3} = {x / cosX:F3}                                 *");
                Console.WriteLine($"* ({x / cosX:F3})^2 = {Math.Pow(x / cosX, 2):F3}                     *");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"* Ошибка: {ex.Message}                                               *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
