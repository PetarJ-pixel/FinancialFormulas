namespace StockBonds
{
    public class DividendsPerShare
    {
        public decimal Dividends { get; set; }
        public decimal NumberOfShares { get; set; }

        public decimal CalculateDividendsPerShare()
        {
            return Dividends / NumberOfShares;
        }
    }
}
