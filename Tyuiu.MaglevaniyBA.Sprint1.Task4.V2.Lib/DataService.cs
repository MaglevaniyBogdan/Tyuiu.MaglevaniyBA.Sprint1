using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task4.V2.Lib
{
    public class DataService : ISprint1Task4V2
    {
        public double Calculate(double X, double Y)
        {
            double result = 1 / Math.Sqrt(X + 2 * Y);
            return Math.Round(result, 3);
        }
    }
}