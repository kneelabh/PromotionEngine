using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineTester.Domain.PromotionLogic;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.PromotionLogic.Tests
{
    [TestClass()]
    public class PromotionType2Tests
    {
        [TestMethod()]
        public void ParseTest()
        {
            float sum = 135;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate();
            PromotionType2 promotionType2 = new PromotionType2();
            var cost = promotionType2.Parse(listItems);

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(3, listItems.Count());
        }

        [TestMethod()]
        public void ParseTestEmptyList()
        {
            float sum = 0;
            PromotionType2 promotionType2 = new PromotionType2();
            var cost = promotionType2.Parse(new List<SKUItems>());

            Assert.AreEqual(sum, cost);
        }

        [TestMethod()]
        public void ParseTestListVar2()
        {
            float sum = 45;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate0Promotion3();
            PromotionType2 promotionType2 = new PromotionType2();
            var cost = promotionType2.Parse(listItems);

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(1, listItems.Count());
        }
    }
}