namespace StockBonds
{
    public class CurrentYield
    {
        public decimal AnnualCoupons { get; set; }
        public decimal CurrentBondPrice { get; set; }

        public decimal CalculateCurrentYield()
        {
            return AnnualCoupons / CurrentBondPrice;
        }
    }
}
