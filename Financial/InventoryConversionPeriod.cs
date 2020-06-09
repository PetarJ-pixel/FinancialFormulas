namespace Financial
{
    public class InventoryConversionPeriod
    {
        public decimal InventoryTurnoverRatio { get; set; }

        public decimal CalculateInventoryConversionPeriod()
        {
            return 365 / InventoryTurnoverRatio;
        }
    }
}
