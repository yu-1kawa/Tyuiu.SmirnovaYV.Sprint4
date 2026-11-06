using Tyuiu.SmirnovaYV.Sprint4.Task2.V2.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds=new DataService();
            int[] numsArray = { 2, 3, 4, 4, 5, 6, 4, 6, 6, 2, 2 };
            int res=ds.Calculate(numsArray);
            int wait = 15;
            Assert.AreEqual(wait, res);
        }
    }
}
