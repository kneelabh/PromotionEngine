using PromotionEngine.Domain.SKU;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain
{
    public class InputParser
    {
        private readonly char[] seperator = { ' ' };
        public List<SKUItems> ParseList(string[] arg)
        {
            List<SKUItems> sKUs = new List<SKUItems>(); 

            foreach (var item in arg)
            {
                var skuData = ParseSKU(item);
                var existingDatainList = sKUs.Where(t => t.sKU.GetType() == skuData.sKU.GetType()).FirstOrDefault();
                if (existingDatainList == null)
                    sKUs.Add(skuData);
                else
                    sKUs.Where(t => t.GetType() == skuData.GetType()).FirstOrDefault().count += skuData.count;
            }

            return sKUs;
        }

        private SKUItems ParseSKU(string skuInfo)
        {
            string[] info = skuInfo.Split(seperator);

            SKUItems sku = new SKUItems();
            switch (info[0].Trim())
            {
                case "A":
                    sku.sKU = new SKU_A();
                    break;
                case "B":
                    sku.sKU = new SKU_B();
                    break;
                case "C":
                    sku.sKU = new SKU_C();
                    break;
                case "D":
                    sku.sKU = new SKU_D();
                    break;
                default:
                    throw new Exception("This SKU is not defined in the system : " + info[0].Trim());
            }
            sku.count = int.Parse(info[1].Trim());

            return sku;
        }
    }
}
