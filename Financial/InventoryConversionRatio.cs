namespace Financial
{
    public class InventoryConversionRatio
    {
        public decimal Sales { get; set; }
        public decimal CostOfGoodsSold { get; set; }

        public decimal CalculateInventoryConversionRatio()
        {
            return (Sales / 2) / CostOfGoodsSold;
        }
    }
}
