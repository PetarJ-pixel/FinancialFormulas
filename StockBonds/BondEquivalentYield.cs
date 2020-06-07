namespace StockBonds
{
    public class BondEquivalentYield
    {
        public decimal FaceValue { get; set; }
        public decimal BondPrice { get; set; }
        public decimal DaysToMaturity { get; set; }

        public decimal CalculateBondEquivalentYield()
        {
            return ((FaceValue - BondPrice) / BondPrice) * (365 / DaysToMaturity);
        }
    }
}
