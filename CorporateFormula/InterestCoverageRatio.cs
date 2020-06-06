namespace CorporateFormula
{
    public class InterestCoverageRatio
    {
        public decimal Ebit { get; set; }
        public decimal InterestExpense { get; set; }

        public decimal CalculateInterestCoverageRatio()
        {
            return Ebit / InterestExpense;
        }
    }
}
