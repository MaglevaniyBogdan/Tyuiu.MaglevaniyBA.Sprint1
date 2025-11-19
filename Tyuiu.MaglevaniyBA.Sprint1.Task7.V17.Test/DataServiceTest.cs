using Tyuiu.MaglevaniyBA.Sprint1.Task7.V17.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = (1 + Math.Sin(Math.Sqrt(x * x + 1))) / Math.Cos(12 * y - 4);
            wait = Math.Round(wait, 3);
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}