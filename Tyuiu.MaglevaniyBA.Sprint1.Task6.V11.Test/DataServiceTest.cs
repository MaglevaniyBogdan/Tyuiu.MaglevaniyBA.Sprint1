using Tyuiu.MaglevaniyBA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool result = ds.CheckeFirstLetterRepetition("aabc");
            Assert.IsTrue(result);
        }
    }
}