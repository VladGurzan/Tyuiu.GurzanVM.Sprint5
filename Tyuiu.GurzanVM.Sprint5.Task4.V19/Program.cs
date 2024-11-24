using Tyuiu.GurzanVM.Sprint5.Task4.V19.Lib;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Гурзан.В.М  | СМАРТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Гурзан Владислав Михайлович |  СМАРТБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле . Вычислить *");
            Console.WriteLine("* значение по формуле (Полученное значение округлить до трёх знаков после *");
            Console.WriteLine("* запятой) и вернуть полученный результат на консоль.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V19.txt" });





            Console.WriteLine("данные находятся в файле " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);

        }
    }
}