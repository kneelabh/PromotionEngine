using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Domain.PromotionLogic;
using PromotionEngineTester.Domain.PromotionLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Domain.PromotionLogic.Tests
{
    [TestClass()]
    public class PromotionType3Tests
    {
        [TestMethod()]
        public void ParseTest()
        {
            float sum = 30;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate();
            PromotionType3 promotionType3 = new PromotionType3();
            var cost = promotionType3.Parse(listItems);

            Assert.AreEqual(cost, sum);
            Assert.AreEqual(listItems.Count(), 3);
        }

        [TestMethod()]
        public void ParseTestEmptyList()
        {
            float sum = 0;
            PromotionType3 promotionType3 = new PromotionType3();
            var cost = promotionType3.Parse(new List<SKUItems>());

            Assert.AreEqual(cost, sum);
        }

        [TestMethod()]
        public void ParseTestListVar2()
        {
            float sum = 30;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate();
            PromotionType3 promotionType3 = new PromotionType3();
            var cost = promotionType3.Parse(listItems);

            Assert.AreEqual(cost, sum);
            Assert.AreEqual(listItems.Count(), 3);
        }
    }
}