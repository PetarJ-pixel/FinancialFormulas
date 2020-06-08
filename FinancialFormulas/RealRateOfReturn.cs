namespace FinancialFormulas
{
    public class RealRateOfReturn
    {
        public decimal NominalRate { get; set; }
        public decimal InflationRate { get; set; }

        public decimal CalculateRealRateOfReturn()
        {
            return ((1 + NominalRate) / (1 + InflationRate) - 1);
        }
    }
}
