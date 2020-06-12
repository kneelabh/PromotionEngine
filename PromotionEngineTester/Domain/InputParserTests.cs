using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.Tests
{
    [TestClass()]
    public class InputParserTests
    {
        [TestMethod()]
        public void ParseListTest()
        {
            Domain.InputParser iPrsr = new InputParser();
            List<string> sKUList = new List<string>();
            var parsedItems = iPrsr.ParseList(sKUList.ToArray());

            Assert.AreEqual(sKUList.Count(), parsedItems.Count());
            Assert.IsNotNull(parsedItems);

        }
    }
}