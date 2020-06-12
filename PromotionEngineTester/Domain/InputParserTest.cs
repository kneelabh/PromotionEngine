using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Domain.Tests
{
    [TestClass()]
    public class InputParserTest
    {
        [TestMethod()]
        public void ParseListTest()
        {
            Domain.InputParser prse = new InputParser();
            List<string> args = new List<string>();
            args.Add("A 5");
            args.Add("B 5");
            args.Add("C 5");

            Assert.AreEqual(prse.ParseList(args.ToArray()).Count(),3);
        }

    }
}