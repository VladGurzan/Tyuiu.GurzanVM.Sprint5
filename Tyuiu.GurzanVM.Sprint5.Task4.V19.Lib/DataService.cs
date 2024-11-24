using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.GurzanVM.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Trim();

            // Проверяем, не является ли строка пустой
            if (string.IsNullOrWhiteSpace(strX))
            {
                throw new FormatException("Файл пуст или не содержит данных.");
            }

            // Пробуем преобразовать строку в число
            double x;
            // Используем CultureInfo.InvariantCulture для обработки чисел
            if (!double.TryParse(strX, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                throw new FormatException($"Строка '{strX}' не содержит корректное числовое значение.");
            }

            // Выполняем расчет
            double res = Math.Round(Math.Pow((x / Math.Cos(x)), 2), 3);
            return res;

        }
    }
}
