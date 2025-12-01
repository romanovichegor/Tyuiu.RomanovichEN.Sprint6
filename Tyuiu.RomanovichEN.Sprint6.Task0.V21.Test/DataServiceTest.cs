using Tyuiu.RomanovichEN.Sprint6.Task0.V21.Lib;
namespace Tyuiu.RomanovichEN.Sprint6.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 50;
            double res = ds.Calculate(3);
            Assert.AreEqual(wait, res);
        }
    }
}
