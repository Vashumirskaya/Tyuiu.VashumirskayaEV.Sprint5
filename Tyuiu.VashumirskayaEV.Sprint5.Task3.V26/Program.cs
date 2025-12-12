using Tyuiu.VashumirskayaEV.Sprint5.Task3.V26.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: [ВашаФамилия] [ВашеИмя] | Вариант #26";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в бинарный файл                                     *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: [ВашаФамилия] [ВашеИмя] | [ВашаГруппа]                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 0.7x^3 + 1.52x^2, вычислить его значение при x = 2*");
            Console.WriteLine("* результат сохранить в бинарный файл OutPutFileTask3.bin                 *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 2;

            Console.WriteLine($"* x = {x}                                                                *");
            Console.WriteLine("* Формула: F(x) = 0.7x³ + 1.52x²                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double manualResult = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            manualResult = Math.Round(manualResult, 3);
            Console.WriteLine($"* Вычисленное значение: {manualResult}                                   *");

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"* Файл создан: {path}                                                    *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("* Содержимое бинарного файла:                                             *");
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    double resultFromFile = reader.ReadDouble();
                    Console.WriteLine($"* {resultFromFile:F3}                                            *");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"* Ошибка чтения файла: {ex.Message}                                  *");
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
