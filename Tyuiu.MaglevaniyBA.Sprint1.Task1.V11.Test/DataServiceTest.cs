using Tyuiu.MaglevaniyBA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task1.V11.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(5, res);


        }
    }
}