using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineTester.Domain;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.PromotionLogic.Tests
{
    [TestClass()]
    public class PromotionType1Tests
    {
        [TestMethod()]
        public void ParseTest()
        {
            float sum = 130;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate();
            PromotionType1 PromotionType1 = new PromotionType1();
            var cost = PromotionType1.Parse(listItems);

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(3, listItems.Count());
        }

        [TestMethod()]
        public void ParseTestEmptyList()
        {
            float sum = 0;
            PromotionType1 PromotionType1 = new PromotionType1();
            var cost = PromotionType1.Parse(new List<SKUItems>());

            Assert.AreEqual(sum, cost);
        }

        [TestMethod()]
        public void ParseTestListVar2()
        {
            float sum = 130;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate0Promotion3();
            PromotionType1 PromotionType1 = new PromotionType1();
            var cost = PromotionType1.Parse(listItems);

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(1, listItems.Count());
        }
    }
}