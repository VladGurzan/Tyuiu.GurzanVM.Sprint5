using Tyuiu.GurzanVM.Sprint5.Task2.V24.Lib;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint5.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
                Assert.AreEqual(wait, fileExists);

        }
    }
}