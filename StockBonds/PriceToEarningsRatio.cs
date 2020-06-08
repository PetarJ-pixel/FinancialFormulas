namespace StockBonds
{
    public class PriceToEarningsRatio
    {
        public decimal PricePerShare { get; set; }
        public decimal EarningsPerShare { get; set; }

        public decimal CalculatePriceToEarningsRatio()
        {
            return PricePerShare / EarningsPerShare;
        }
    }
}
