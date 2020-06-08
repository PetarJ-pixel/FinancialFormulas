namespace StockBonds
{
    public class StockPresentValuesWithZaroGrowth
    {
        public decimal DividendsPerPeriod { get; set; }
        public decimal RequiredRateOfReturn { get; set; }

        public decimal CalculateStockPresentValuesWithZaroGrowth()
        {
            return DividendsPerPeriod / RequiredRateOfReturn;
        }
    }
}
