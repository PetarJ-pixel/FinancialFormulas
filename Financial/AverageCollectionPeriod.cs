namespace Financial
{
    public class AverageCollectionPeriod
    {
        public decimal AccountsReceivable { get; set; }
        public decimal AnnualCreditSales { get; set; }

        public decimal CalculateAverageCollectionPeriod()
        {
            return AccountsReceivable / (AnnualCreditSales / 365);
        }
    }
}
