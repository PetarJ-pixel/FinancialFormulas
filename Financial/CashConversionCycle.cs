namespace Financial
{
    public class CashConversionCycle
    {
        public decimal InventoryConversionPeriod { get; set; }
        public decimal ReceivablesConversionPeriod { get; set; }
        public decimal PayablesConversionPeriod { get; set; }

        public decimal CalculateCashConversionCycle()
        {
            return InventoryConversionPeriod + ReceivablesConversionPeriod - PayablesConversionPeriod;
        }
    }
}
