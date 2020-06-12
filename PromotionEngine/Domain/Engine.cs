using PromotionEngine.Domain.PromotionLogic;
using System.Collections.Generic;

namespace PromotionEngine.Domain
{
    public class Engine
    {
        public float ParseCost(List<SKUItems> sKUItems)
        {
            float totalCost = 0;
            IPromotionLogic runningPromotion;

            runningPromotion = new PromotionType1();
            totalCost += runningPromotion.Parse(sKUItems);

            runningPromotion = new PromotionType2();
            totalCost += runningPromotion.Parse(sKUItems);

            runningPromotion = new PromotionType3();
            totalCost += runningPromotion.Parse(sKUItems);


            foreach (var item in sKUItems)
            {
                totalCost += item.count * item.sKU.GetCost();
            }

            return totalCost;
        }

    }
}
