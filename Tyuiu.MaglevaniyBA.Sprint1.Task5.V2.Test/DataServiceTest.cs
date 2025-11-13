using Tyuiu.MaglevaniyBA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double tempF = 32.0;
            int expected = 0;

            
            int result = ds.FahrenheitTo—elsius(tempF);

            
            Assert.AreEqual(expected, result);
        }
    }
}