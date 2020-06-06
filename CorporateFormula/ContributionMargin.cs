namespace CorporateFormula
{
    public class ContributionMargin
    {
        public decimal PricePerProduct { get; set; }
        public decimal VariableCostPerProduct { get; set; }

        public decimal CalculateContributionMargin()
        {
            return PricePerProduct - VariableCostPerProduct;
        }
    }
}
