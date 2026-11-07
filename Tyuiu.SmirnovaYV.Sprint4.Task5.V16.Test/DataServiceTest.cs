using Tyuiu.SmirnovaYV.Sprint4.Task5.V16.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task5.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -6,-5,-5,-4,-3 }, { 1,2,3,1,2 }, { -6,2,-5,1,-4 }, { 1,-1,2,-2,3 }, { -1,-2,2,-2,-1 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -6, -5, -5, -4, -3 }, { 1, 1, 1, 1, 1 }, { -6, 1, -5, 1, -4 }, { 1, -1, 1, -2, 1 }, { -1, -2, 1, -2, -1 } } ;
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
