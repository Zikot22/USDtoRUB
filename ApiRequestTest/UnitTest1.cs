using Logic;

namespace ApiRequestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetExchangeRateTest()
        {
            CurrencyConverter converter = new();
            converter.SetExchangeRate();
            double result = converter.ExchangeRate;
            Assert.IsTrue(result > 0);
        }
    }
}