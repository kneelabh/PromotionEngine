using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine.Domain.SKU
{
    public struct SKU_C :ISKU
    {
        public string SKU_Id
        {
            get
            {
                return "C";
            }
        }
        private float cost
        {
            get
            {
                return 20;
            }
        }
        public float GetCost()
        {
            return cost;
        }
    }
}
