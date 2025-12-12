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
            Console.WriteLine("* (последовательностей из 2+ пробелов) в заданной строке.                 *");
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
                Console.WriteLine("* АНАЛИЗ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("* Визуализация (• - пробел):                                          *");
                string visualContent = fileContent.Replace(' ', '•');
                Console.WriteLine($"* {visualContent}                                                       *");

                int seqCount = 0;
                int currentSeqLength = 0;

                for (int i = 0; i < fileContent.Length; i++)
                {
                    if (fileContent[i] == ' ')
                    {
                        currentSeqLength++;
                    }
                    else
                    {
                        if (currentSeqLength >= 2)
                        {
                            seqCount++;
                            Console.WriteLine($"* Последовательность {seqCount}: {currentSeqLength} пробелов                *");
                        }
                        currentSeqLength = 0;
                    }
                }

                if (currentSeqLength >= 2)
                {
                    seqCount++;
                    Console.WriteLine($"* Последовательность {seqCount}: {currentSeqLength} пробелов                *");
                }

                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"* КОЛИЧЕСТВО ПОСЛЕДОВАТЕЛЬНОСТЕЙ ИЗ 2+ ПРОБЕЛОВ: {result,15} *");

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
