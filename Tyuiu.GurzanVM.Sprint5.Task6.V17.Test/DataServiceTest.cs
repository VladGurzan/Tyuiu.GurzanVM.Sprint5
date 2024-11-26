using Tyuiu.GurzanVM.Sprint5.Task6.V17.Lib;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            var res = ds.LoadFromDataFile(path);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool filenfo = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, filenfo);

        }





    }
}