using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineTester.Domain;

namespace PromotionEngine.Domain.Tests
{
    [TestClass()]
    public class EngineTests
    {
        [TestMethod()]
        public void ParseCostTest()
        {
            DummyCart dummyCart = new DummyCart();

            Domain.Engine engine = new Engine();
            var cost = engine.ParseCost(dummyCart.Generate());

            Assert.AreEqual(465, cost);
        }

    }
}