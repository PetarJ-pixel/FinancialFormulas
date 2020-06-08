namespace StockBonds
{
    public class TotalStockReturnPercentage
    {
        public decimal InitialStockPrice { get; set; }
        public decimal EndingStockPrice { get; set; }
        public decimal Dividends { get; set; }

        public decimal CalculateTotalStockReturnPercentage()
        {
            return ((EndingStockPrice - InitialStockPrice) + Dividends) / InitialStockPrice;
        }
    }
}
