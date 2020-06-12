namespace PromotionEngine.Domain.SKU
{
    public struct SKU_B : ISKU
    {
        public string SKU_Id
        {
            get
            {
                return "B";
            }
        }
        private float cost
        {
            get
            {
                return 30;
            }
        }

        public float GetCost()
        {
            return cost;
        }
    }
}
