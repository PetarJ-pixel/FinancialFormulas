namespace StockBonds
{
    public class EquityMultiplier
    {
        public decimal TotalAssets { get; set; }
        public decimal StacholedersEquity { get; set; }

        public decimal CalculateEquityMultiplier()
        {
            return TotalAssets / StacholedersEquity;
        }
    }
}
