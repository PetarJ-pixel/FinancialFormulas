namespace CorporateFormula
{
    public class DebtCoverageRatio
    {
        public decimal NetOperatingIncome { get; set; }
        public decimal DebtService { get; set; }

        public decimal CalculateDebtCoverageRatio()
        {
            return NetOperatingIncome / DebtService;
        }
    }
}
