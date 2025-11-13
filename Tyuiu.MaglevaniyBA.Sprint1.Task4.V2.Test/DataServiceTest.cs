using Tyuiu.MaglevaniyBA.Sprint1.Task4.V2.Lib;
namespace Tyuiu.MaglevaniyBA.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            DataService ds = new DataService();
            double x = 4;
            double y = 5;

            
            double expected = 0.267;
            
            double result = ds.Calculate(x, y);

            
            Assert.AreEqual(expected, result);
        }
    }
}