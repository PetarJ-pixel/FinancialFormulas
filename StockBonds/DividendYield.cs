namespace StockBonds
{
    public class DividendYield
    {
        public decimal DividendsForThePeriod { get; set; }
        public decimal InitialPriceForThePeriod { get; set; }

        public decimal CalculateDividendYield()
        {
            return DividendsForThePeriod / InitialPriceForThePeriod;
        }
    }
}
