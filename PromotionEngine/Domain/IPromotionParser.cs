using System.Collections.Generic;

namespace PromotionEngine.Domain
{
    public interface IPromotionLogic
    {
        float Parse(List<SKUItems> sKUs);
    }
}
