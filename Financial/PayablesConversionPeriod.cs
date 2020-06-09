namespace Financial
{
    public class PayablesConversionPeriod
    {
        public decimal AccountsPayable { get; set; }
        public decimal Purchases { get; set; }

        public decimal CalculatePayablesConversionPeriod()
        {
            return (AccountsPayable / Purchases) * 365;
        }
    }
}
