namespace CorporateFormula
{
    public class DebtToEquityRatio
    {
        public decimal TotalLiabilities { get; set; }
        public decimal TotalEquity { get; set; }

        public decimal CalculateDebtToEquityRatio()
        {
            return TotalLiabilities / TotalEquity;
        }
    }
}
