using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SmirnovaYV.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int multArray = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 1)
                {
                    multArray *= array[i];
                }
            }
            return multArray;
        }
    }
}
