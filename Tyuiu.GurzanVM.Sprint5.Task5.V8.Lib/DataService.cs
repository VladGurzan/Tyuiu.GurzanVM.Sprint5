using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Runtime.CompilerServices;

namespace Tyuiu.GurzanVM.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double res;
            double minValue = int.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                res = Convert.ToDouble(line);
                while ((line = reader.ReadLine()) != null)
                {
                    
                    if (Convert.ToDouble(line) < minValue)
                        minValue = Math.Round(Convert.ToDouble(line), 3);
                }
                return minValue;
            }
        }
    }
}
