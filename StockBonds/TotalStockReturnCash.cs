namespace StockBonds
{
    public class TotalStockReturnCash
    {
        public decimal InitialStockPrice { get; set; }
        public decimal EndingStockPrice { get; set; }
        public decimal Dividends { get; set; }

        public decimal CalculateTotalStockReturnCash()
        {
            return (EndingStockPrice - InitialStockPrice) + Dividends;
        }
    }
}
