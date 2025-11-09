using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            double totalDistance = distance * 2; 
            double totalGas = totalDistance * (gasFlow / 100); 
            double cost = totalGas * gasPrice; 
            return Math.Round(cost, 3); 
        }
    }
}
