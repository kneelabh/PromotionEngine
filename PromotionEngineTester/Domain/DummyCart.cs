using PromotionEngine.Domain;
using PromotionEngine.Domain.SKU;
using System.Collections.Generic;

namespace PromotionEngineTester.Domain
{
    public class DummyCart
    {
        public List<SKUItems> Generate()
        {
            List<SKUItems> items = new List<SKUItems>();

            items.Add(new SKUItems() { count = 5, sKU = new SKU_A() });
            items.Add(new SKUItems() { count = 7, sKU = new SKU_B() });
            items.Add(new SKUItems() { count = 3, sKU = new SKU_C() });
            items.Add(new SKUItems() { count = 1, sKU = new SKU_D() });


            return items;
        }

        public List<SKUItems> Generate0Promotion3()
        {
            List<SKUItems> items = new List<SKUItems>();

            items.Add(new SKUItems() { count = 5, sKU = new SKU_A() });
            items.Add(new SKUItems() { count = 2, sKU = new SKU_B() });


            return items;
        }

        public List<string> RawCart()
        {
            List<string> listSKUCart = new List<string>();
            listSKUCart.Add("A 5");
            listSKUCart.Add("B 3");
            listSKUCart.Add("C 1");
            return listSKUCart;
        }
    }
}
