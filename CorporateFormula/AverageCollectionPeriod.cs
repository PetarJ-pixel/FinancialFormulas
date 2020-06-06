namespace CorporateFormula
{
    public class AverageCollectionPeriod
    {
        public decimal ReceivablesPeriod { get; set; }

        public decimal CalculateAverageCollectionPeriod()
        {
            return 365 / ReceivablesPeriod;
        }
    }
}
