using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SmirnovaYV.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            int res = 1;
            int mainColumn = 3;
            for (int i = 0; i < rows; i++)
            {
                res= res * array[i, mainColumn];
            }
            return res;
        }
    }
}
