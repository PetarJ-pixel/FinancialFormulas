namespace StockBonds
{
    public class CapitalGainsYield
    {
        public decimal InitialStockPrice { get; set; }
        public decimal EndingStockPrice { get; set; }

        public decimal CalculateCapitalGainsYield()
        {
            return (EndingStockPrice - InitialStockPrice) / InitialStockPrice;
        }
    }
}
