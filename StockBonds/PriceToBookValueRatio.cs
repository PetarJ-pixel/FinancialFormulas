namespace StockBonds
{
    public class PriceToBookValueRatio
    {
        public decimal MarketPricePerShare { get; set; }
        public decimal BookValuePerShare { get; set; }

        public decimal CalculatePriceToBookValueRatio()
        {
            return MarketPricePerShare / BookValuePerShare;
        }
    }
}
