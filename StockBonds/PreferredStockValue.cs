namespace StockBonds
{
    public class PreferredStockValue
    {
        public decimal Dividend { get; set; }
        public decimal DiscountRate { get; set; }

        public decimal CalculatePreferredStockValue()
        {
            return Dividend / DiscountRate;
        }
    }
}
