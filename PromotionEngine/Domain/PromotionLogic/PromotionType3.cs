using PromotionEngine.Domain.SKU;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.PromotionLogic
{
    public class PromotionType3 : IPromotionLogic
    {
        float cost;
        ISKU offerSKU1, offerSKU2;
        public float Parse(List<SKUItems> listSKU)
        {
            float totalCost = 0;
            SKUItems eligibleItems1 = listSKU.Where(t => t.sKU.GetType() == offerSKU1.GetType()).FirstOrDefault();
            SKUItems eligibleItems2 = listSKU.Where(t => t.sKU.GetType() == offerSKU2.GetType()).FirstOrDefault();

            int maxEqual = 0;
            if (eligibleItems1 != null && eligibleItems2 != null)
            {
                if (eligibleItems1.count < eligibleItems2.count)
                {
                    maxEqual = eligibleItems1.count;
                    listSKU.Remove(eligibleItems1);
                    listSKU.Where(t => t == eligibleItems2).FirstOrDefault().count -= maxEqual; 
                }
                else if (eligibleItems2.count < eligibleItems1.count)
                {
                    maxEqual = eligibleItems2.count;
                    listSKU.Remove(eligibleItems2);
                    listSKU.Where(t => t == eligibleItems1).FirstOrDefault().count -= maxEqual;
                }
                else
                {
                    maxEqual = eligibleItems2.count;
                    listSKU.Remove(eligibleItems1);
                    listSKU.Remove(eligibleItems2);
                }
            }
            totalCost = maxEqual * cost;
            return totalCost;
        }


        public PromotionType3()
        {
            offerSKU1 = new SKU_C();
            offerSKU2 = new SKU_D();
            cost = 30;
        }
    }
}
