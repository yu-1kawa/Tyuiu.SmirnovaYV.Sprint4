using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SmirnovaYV.Sprint4.Task1.V9.Lib
{
    public class DataService : ISprint4Task1V9
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
