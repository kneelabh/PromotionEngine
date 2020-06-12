using PromotionEngine.Domain;
using PromotionEngine.Domain.SKU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineTester.Domain.PromotionLogic
{
    public class DummyCart
    {
        public List<SKUItems> Generate()
        {
            List<SKUItems> items = new List<SKUItems>();

            items.Add(new SKUItems() { count = 5, sKU = new SKU_A() });
            items.Add(new SKUItems() { count = 2, sKU = new SKU_B() });
            items.Add(new SKUItems() { count = 3, sKU = new SKU_C() });
            items.Add(new SKUItems() { count = 1, sKU = new SKU_D() });


            return items;
        }
    }
}
