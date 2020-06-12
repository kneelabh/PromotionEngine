using PromotionEngine.Domain.SKU;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.PromotionLogic
{
    public class PromotionType1 : IPromotionLogic
    {
        int countOfSKU;
        float cost;
        ISKU offerSKU;
        public float Parse(List<SKUItems> listSKU)
        {
            float totalCost = 0;
            var eligibleItems = listSKU.Where(t => t.sKU.GetType() == offerSKU.GetType()).FirstOrDefault();

            if (eligibleItems != null)
            {
                listSKU.Remove(eligibleItems);
                totalCost = (eligibleItems.count / countOfSKU) * cost;
            }
            return totalCost;
        }

        public PromotionType1()
        {
            offerSKU = new SKU_A();
            cost = 130;
            countOfSKU = 3;
        }
    }
}
