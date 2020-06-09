namespace Financial
{
    public class ReceivablesConversionPeriod
    {
        public decimal Receivables { get; set; }
        public decimal NetSales { get; set; }

        public decimal CalculateReceivablesConversionPeriod()
        {
            return (Receivables / NetSales) * 365;
        }
    }
}
