namespace StockBonds
{
    public class TaxEquivalentYield
    {
        public decimal TaxFreeYield { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTaxEquivalentYield()
        {
            return TaxFreeYield / (1 - TaxRate);
        }
    }
}
