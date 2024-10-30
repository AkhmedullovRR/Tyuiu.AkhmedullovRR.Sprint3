using Tyuiu.AkhmedullovRR.Sprint3.Task6.V18.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SearchingValid()
        {
            DataService ds = new DataService();
            int start = 9, end = 18;
            Assert.AreEqual(95, ds.GetSumTheDivisors(start, end));
        }
    }
}