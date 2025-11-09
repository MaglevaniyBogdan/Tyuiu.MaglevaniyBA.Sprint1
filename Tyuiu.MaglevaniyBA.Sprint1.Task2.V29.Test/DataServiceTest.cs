using Tyuiu.MaglevaniyBA.Sprint1.Task2.V29.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
            [TestMethod]

            public void ValidExpression()
            {
                DataService ds = new DataService();

                int x = 60;

                int res = ds.ConvertSecondsToHours(x);

                Assert.AreEqual(1, res);

            }

    }
}