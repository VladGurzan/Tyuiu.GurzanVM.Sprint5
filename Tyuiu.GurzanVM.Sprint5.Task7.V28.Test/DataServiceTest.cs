namespace Tyuiu.GurzanVM.Sprint5.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt " });
            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}