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
            Console.WriteLine("* Формула: y = (x / cos(x))^2                                             *");
            Console.WriteLine("* Вычислить значение и вернуть полученный результат на консоль.           *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V19.txt";

            Console.WriteLine($"* Файл с данными: {path}                                                 *");

            string directory = @"C:\DataSprint5";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                Console.WriteLine($"* Создана папка: {directory}                                         *");
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "2.67");
                Console.WriteLine($"* Создан файл с тестовыми данными: {path}                            *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                string xValue = File.ReadAllText(path).Trim();
                Console.WriteLine($"* Значение X из файла: {xValue}                                      *");
                Console.WriteLine($"* Формула: y = (x / cos(x))^2                                        *");
                Console.WriteLine($"* Результат (округлено до 3 знаков): {result:F3}                     *");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("* Ошибка: Файл не найден!                                             *");
            }
            catch (FormatException)
            {
                Console.WriteLine("* Ошибка: Неверный формат данных в файле!                             *");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"* Ошибка: {ex.Message}                                               *");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"* Неизвестная ошибка: {ex.Message}                                   *");
            }

            Console.WriteLine("***************************************************************************");

            Console.WriteLine("* Содержимое файла:                                                       *");
            try
            {
                string fileContent = File.ReadAllText(path);
                Console.WriteLine($"* {fileContent}                                                      *");
            }
            catch
            {
                Console.WriteLine("* Не удалось прочитать файл                                           *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
