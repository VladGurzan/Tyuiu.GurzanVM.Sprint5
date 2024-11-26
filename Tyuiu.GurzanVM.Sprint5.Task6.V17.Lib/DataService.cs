using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GurzanVM.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            
            int count = 0;
            int consecutiveSpaces = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i] == ' ' && line[i - 1] == ' ')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        
        }
    }
}
