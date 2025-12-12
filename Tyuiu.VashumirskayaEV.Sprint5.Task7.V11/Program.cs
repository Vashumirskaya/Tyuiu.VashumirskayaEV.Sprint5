using Tyuiu.VashumirskayaEV.Sprint5.Task7.V11.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V11.txt";

            Console.Title = "Спринт #5 | Выполнила: Вашумирская Е. В. | СМАРТ-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Работа с файлами                                                 *");
            Console.WriteLine("* Задание #11                                                            *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТ-25-1             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Из файла удалить все пробелы и строчные русские буквы.                 *");
            Console.WriteLine("* Результат сохранить в файл OutPutDataFileTask7V11.txt.                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine($"* Исходный файл: {path}");
            Console.WriteLine("**************************************************************************");

            string resultFile = ds.LoadDataAndSave(path);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine($"* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine($"* Новый файл: {resultFile}");
            Console.WriteLine("**************************************************************************");

            Console.ReadKey();
        }
    }
}
