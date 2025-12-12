using Tyuiu.VashumirskayaEV.Sprint5.Task1.V27.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint5.Task1.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: [ВашаФамилия] [ВашеИмя] | Вариант #27";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: [ВашаФамилия] [ВашеИмя] | [ВашаГруппа]                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (3x - 1.5)/(sin(x) - 3 + x) + 2                     *");
            Console.WriteLine("* Произвести табулирование на диапазоне [-5; 5] с шагом 1.                *");
            Console.WriteLine("* При делении на ноль вернуть 0.                                          *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask1.txt                          *");
            Console.WriteLine("* Округлить до двух знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"* Стартовое значение = {startValue}                                      *");
            Console.WriteLine($"* Конечное значение = {stopValue}                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл создан: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Таблица значений функции:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("|   x   |   F(x)   |");
            Console.WriteLine("|-------|----------|");

            string[] lines = File.ReadAllLines(path);
            int x = startValue;

            foreach (string line in lines)
            {
                Console.WriteLine($"| {x,5} | {line,8} |");
                x++;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Содержимое файла (как есть):");
            Console.WriteLine("***************************************************************************");

            string fileContent = File.ReadAllText(path);
            Console.WriteLine(fileContent);

            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
