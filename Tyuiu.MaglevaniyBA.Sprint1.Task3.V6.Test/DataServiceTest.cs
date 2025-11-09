using Tyuiu.MaglevaniyBA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTravelCost()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;
            double wait = 74.035;
            double res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(wait, res);
        }
    }
}