using System.Text.Json.Serialization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GurzanVM.Sprint5.Task2.V24.Lib
{
    public class DataService : ISprint5Task2V24
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.GetTempFileName();

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            
            int rows = matrix.GetUpperBound(0) + 1;
            int colu = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                
                }
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colu; j++)
                {
                    if (j != colu - 1)
                    {
                        str = str + matrix[i, j] + ";";
                    }
                    else
                    {
                        str = str + matrix[i, j];
                    }
                
                }

                if (i != rows - 1)
                {
                    File.AppendAllText(path, str + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str);
                }

                str = "";


            
            }
            return path;    
        }
    }
}
