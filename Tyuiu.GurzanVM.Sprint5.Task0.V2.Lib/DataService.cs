using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.Combine()}OutPutFileTask0.txt";
            double z = (Math.Pow(double.E, x) / x);
            z = Math.Round(z, 3);   
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
