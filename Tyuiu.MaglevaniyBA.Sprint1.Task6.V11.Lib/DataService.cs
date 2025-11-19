using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MaglevaniyBA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            char firstLetter = value[0];

            for(int i = 1; i < value.Length; i++) {
                if (firstLetter == value[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
