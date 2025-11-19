using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double A = 1 + Math.Sin(Math.Sqrt(x * x + 1));
            double B = Math.Cos(12 * y - 4);
            double res = A / B;
            return Math.Round(res, 3);
        }
    }
}
