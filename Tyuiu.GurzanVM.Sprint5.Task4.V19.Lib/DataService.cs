using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;

namespace Tyuiu.GurzanVM.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            double res = Math.Pow(Convert.ToDouble(strx) / Math.Cos(Convert.ToDouble(strx)), 2);
            res = Math.Round(res, 3);
            return res;

        }
    }
}
