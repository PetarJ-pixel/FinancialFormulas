namespace Financial
{
    public class DebtServiceCoverageRatio
    {
        public decimal NetOperatingIncome { get; set; }
        public decimal TotalDebtService { get; set; }

        public decimal CalculateDebtServiceCoverageRatio()
        {
            return NetOperatingIncome / TotalDebtService;
        }
    }
}
