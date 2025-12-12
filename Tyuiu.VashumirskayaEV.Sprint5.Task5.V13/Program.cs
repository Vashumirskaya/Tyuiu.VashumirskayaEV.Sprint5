using Tyuiu.VashumirskayaEV.Sprint5.Task5.V13.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: [ВашаФамилия] [ВашеИмя] | Вариант #13";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: [ВашаФамилия] [ВашеИмя] | [ВашаГруппа]                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором значений.                                            *");
            Console.WriteLine("* Найти среднее значение всех чисел в файле, которые находятся            *");
            Console.WriteLine("* в промежутке от -1.5 до 1.5.                                            *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V13.txt";

            Console.WriteLine($"* Файл с данными: {path}                                                 *");

            string directory = @"C:\DataSprint5";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                Console.WriteLine($"* Создана папка: {directory}                                         *");
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "-1 18.45 -1 -3 18 20 8 -5 -8 -6.63 17.98 7 4.83 3.26 12.54 -8.03 13.64 -4.59 12.87 20");
                Console.WriteLine($"* Создан файл с тестовыми данными                                   *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                Console.WriteLine("* Содержимое файла:                                                   *");
                string fileContent = File.ReadAllText(path);
                Console.WriteLine($"* {fileContent}                                                      *");

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* АНАЛИЗ ДАННЫХ:                                                       *");
                Console.WriteLine("***************************************************************************");

                string[] numbers = fileContent.Split(new char[] { ' ', '\t', '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine("* Всего чисел в файле: {0,34} *", numbers.Length);

                int countInRange = 0;
                double sumInRange = 0;

                Console.WriteLine("* Числа в диапазоне от -1.5 до 1.5:                                  *");
                foreach (string numStr in numbers)
                {
                    if (double.TryParse(numStr, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double number))
                    {
                        if (number >= -1.5 && number <= 1.5)
                        {
                            Console.WriteLine($"* {number,52:F3} *");
                            countInRange++;
                            sumInRange += number;
                        }
                    }
                }

                if (countInRange == 0)
                {
                    Console.WriteLine("* Нет чисел в указанном диапазоне                                         *");
                }
                else
                {
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine($"* Количество чисел в диапазоне: {countInRange,28} *");
                    Console.WriteLine($"* Сумма чисел в диапазоне: {sumInRange,30:F3} *");
                }

                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"* СРЕДНЕЕ ЗНАЧЕНИЕ (округлено до 3 знаков): {result,16:F3} *");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("* ОШИБКА: Файл не найден! Проверьте путь к файлу.                     *");
            }
            catch (FormatException)
            {
                Console.WriteLine("* ОШИБКА: Неверный формат данных в файле!                             *");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"* ОШИБКА: {ex.Message}                                               *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
