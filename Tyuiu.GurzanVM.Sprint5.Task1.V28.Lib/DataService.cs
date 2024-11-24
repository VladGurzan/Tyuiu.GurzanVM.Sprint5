using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round((Math.Cos(i) / i - 0.7) - Math.Sin(i) * (12 * i) + 2, 2);
                strY = Convert.ToString(y);

                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            
            }

        
        return path;
        }
    }
}
