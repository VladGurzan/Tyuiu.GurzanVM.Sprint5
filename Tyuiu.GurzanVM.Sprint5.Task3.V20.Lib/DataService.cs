using tyuiu.cources.programming.interfaces.Sprint5;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task3.V20.Lib
{
    public class DataService : ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double y = (x / (Math.Sqrt(Math.Pow(x, 2) + x)));
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
        
            return path;
        }
    }
}
