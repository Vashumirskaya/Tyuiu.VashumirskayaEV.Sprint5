using Tyuiu.VashumirskayaEV.Sprint5.Task6.V17.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: [ВашаФамилия] [ВашеИмя] | Вариант #17";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: [ВашаФамилия] [ВашеИмя] | [ВашаГруппа]                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл с набором символьных данных.                                   *");
            Console.WriteLine("* Найти количество пробелов, идущих подряд больше одного                 *");
            Console.WriteLine("* (последовательности из 2+ пробелов) в заданной строке.                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V17.txt";

            Console.WriteLine($"* Файл с данными: {path}                                                *");

            string directory = @"C:\DataSprint5";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                Console.WriteLine($"* Создана папка: {directory}                                        *");
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Это  пример  строки с лишними пробелами.");
                Console.WriteLine($"* Создан файл с тестовыми данными                                   *");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                int result = ds.LoadFromDataFile(path);

                Console.WriteLine("* Содержимое файла:                                                   *");
                string fileContent = File.ReadAllText(path);
                Console.WriteLine($"* \"{fileContent}\"                                                   *");

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* АНАЛИЗ ДАННЫХ:                                                       *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("* Поиск последовательностей из 2+ пробелов:                           *");

                string content = fileContent;
                bool inSequence = false;
                int seqStart = -1;
                int seqCount = 0;

                for (int i = 0; i < content.Length; i++)
                {
                    if (content[i] == ' ')
                    {
                        if (!inSequence)
                        {
                            inSequence = true;
                            seqStart = i;
                        }
                    }
                    else
                    {
                        if (inSequence)
                        {
                            int seqLength = i - seqStart;
                            if (seqLength >= 2)
                            {
                                Console.WriteLine($"* Последовательность [{seqStart}-{i - 1}]: {seqLength} пробелов              *");
                                seqCount++;
                            }
                            inSequence = false;
                        }
                    }
                }

                if (inSequence)
                {
                    int seqLength = content.Length - seqStart;
                    if (seqLength >= 2)
                    {
                        Console.WriteLine($"* Последовательность [{seqStart}-{content.Length - 1}]: {seqLength} пробелов        *");
                        seqCount++;
                    }
                }

                if (seqCount == 0)
                {
                    Console.WriteLine("* Последовательностей из 2+ пробелов не найдено                   *");
                }
                else
                {
                    Console.WriteLine($"* Найдено последовательностей: {seqCount}                               *");
                }

                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"* ОБЩЕЕ КОЛИЧЕСТВО ПРОБЕЛОВ В ПОСЛЕДОВАТЕЛЬНОСТЯХ ИЗ 2+: {result,10} *");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("* ОШИБКА: Файл не найден! Проверьте путь к файлу.                     *");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"* ОШИБКА: {ex.Message}                                               *");
            }

            Console.WriteLine("***************************************************************************");


            Console.WriteLine("* Визуализация пробелов в строке (• - пробел):                          *");
            string visualContent = File.ReadAllText(path).Replace(' ', '•');
            Console.WriteLine($"* {visualContent}                                                       *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
