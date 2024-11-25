using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tyuiu.GurzanVM.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            
            double minValue = int.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) < minValue)
                    {
                        minValue = Convert.ToDouble(line);
                    }
                }
            }
            minValue = Math.Round(minValue, 3);
            return minValue;
        }
    }
}
