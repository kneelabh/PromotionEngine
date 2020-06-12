﻿namespace PromotionEngine.Domain.SKU
{
    public struct SKU_D : ISKU
    {
        public string SKU_Id
        {
            get
            {
                return "D";
            }
        }
        private float cost
        {
            get
            {
                return 15;
            }
        }
        public float GetCost()
        {
            return cost;
        }
    }
}
