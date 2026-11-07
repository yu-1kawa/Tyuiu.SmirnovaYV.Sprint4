using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SmirnovaYV.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;
            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i,j]%2==0)
                    {
                        res+=matrix[i,j];
                    }
                }
            }
            return res;
        }
    }
}
