namespace StockBonds
{
    public class TotalStockReturnFromYields
    {
        public decimal DividendYield { get; set; }
        public decimal CapitalGainsYield { get; set; }

        public decimal CalculateTotalStockReturnFromYields()
        {
            return DividendYield + CapitalGainsYield;
        }
    }
}
