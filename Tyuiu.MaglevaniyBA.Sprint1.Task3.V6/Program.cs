using Tyuiu.MaglevaniyBA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task3.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Маглёваный Б. А. | НТм-24-1";


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы по С#                                      *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Маглёваный Богдан Александрович | НТм-24-1                   *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу которая вычисляет выражение 3 * 4 + 10 / 2          *");
            Console.WriteLine("* и печатает результат на экран.                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 3 * 4 + 10 / 2                                                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double distance = double.Parse(Console.ReadLine());

            double gasFlow = double.Parse(Console.ReadLine());

            double gasPrice = double.Parse(Console.ReadLine());
            Console.WriteLine(ds.TravelCost(distance, gasFlow, gasPrice));

            Console.ReadLine();
        }
    }
}
