namespace PromotionEngine.Domain.SKU
{
    public struct SKU_A : ISKU
    {
        public string SKU_Id
        {
            get
            {
                return "A";
            }
        }
        private float cost
        {
            get
            {
                return 50;
            }
        }

        public float GetCost()
        {
            return cost;
        }
    }
}
