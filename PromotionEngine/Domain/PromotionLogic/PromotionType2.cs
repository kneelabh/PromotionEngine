using PromotionEngine.Domain.SKU;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine.Domain.PromotionLogic
{
    public class PromotionType2 : IPromotionLogic
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


        public PromotionType2()
        {
            offerSKU = new SKU_B();
            cost = 45;
            countOfSKU = 2;
        }
    }
}
