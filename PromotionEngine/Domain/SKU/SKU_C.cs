﻿namespace PromotionEngine.Domain.SKU
{
    public struct SKU_C : ISKU
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
