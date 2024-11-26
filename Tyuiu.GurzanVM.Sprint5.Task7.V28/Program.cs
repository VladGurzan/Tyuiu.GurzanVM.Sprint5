using Tyuiu.GurzanVM.Sprint5.Task7.V28.Lib;
namespace Tyuiu.GurzanVM.Sprint5.Task7.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Заменить все пробелы, идущие подряд более одного, на один пробел.       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V28.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt" });
            string pathSaveFile = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt" });

            Console.WriteLine("Данные находтся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(pathSaveFile);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}