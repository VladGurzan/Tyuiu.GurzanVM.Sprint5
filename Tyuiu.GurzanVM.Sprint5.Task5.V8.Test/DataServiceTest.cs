
namespace Tyuiu.GurzanVM.Sprint5.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask5V8.txt" });
            FileInfo fileInfo = new FileInfo(path);
            bool filenfo = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, filenfo);
        }
    }
}