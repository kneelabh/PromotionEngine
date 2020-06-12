using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Domain.PromotionLogic;
using PromotionEngine.Domain.SKU;
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

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(3, listItems.Count());
            Assert.AreEqual(2, listItems.Where(t => t.sKU.GetType() == typeof(SKU_C)).FirstOrDefault().count);
        }

        [TestMethod()]
        public void ParseTestEmptyList()
        {
            float sum = 0;
            PromotionType3 promotionType3 = new PromotionType3();
            var cost = promotionType3.Parse(new List<SKUItems>());

            Assert.AreEqual(sum, cost);
        }

        [TestMethod()]
        public void ParseTestListVar2()
        {
            float sum = 0;
            DummyCart dummyCart = new DummyCart();
            var listItems = dummyCart.Generate0Promotion3();
            PromotionType3 promotionType3 = new PromotionType3();
            var cost = promotionType3.Parse(listItems);

            Assert.AreEqual(sum, cost);
            Assert.AreEqual(2, listItems.Count());
        }
    }
}