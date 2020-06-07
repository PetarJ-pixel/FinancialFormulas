namespace StockBonds
{
    public class DividendPayoutRatio
    {
        public decimal Dividends { get; set; }
        public decimal NetIncome { get; set; }

        public decimal CalculateDividendPayoutRatio()
        {
            return Dividends / NetIncome;
        }
    }
}
