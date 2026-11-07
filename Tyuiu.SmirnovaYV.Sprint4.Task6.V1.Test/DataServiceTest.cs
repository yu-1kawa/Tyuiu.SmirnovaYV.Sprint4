using Tyuiu.SmirnovaYV.Sprint4.Task6.V1.Lib;
namespace Tyuiu.SmirnovaYV.Sprint4.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds=new DataService();
            var frut = new string[] { "Яблко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
            int res= ds.Calculate(frut);
            int wait = 2;
            Assert.AreEqual(wait,res);
        }
    }
}
