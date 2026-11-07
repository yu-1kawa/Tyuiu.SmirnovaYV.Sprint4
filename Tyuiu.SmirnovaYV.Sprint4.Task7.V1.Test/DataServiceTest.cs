using System.Data.Common;
using Tyuiu.SmirnovaYV.Sprint4.Task7.V1.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int rows = 3;
            int columns = 3;
            int[,] mtrx=new int[rows, columns];
            string str = "135792468";
            DataService ds=new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait,res);
        }
    }
}
