namespace Financial
{
    public class InventoryTurnover
    {
        public decimal Sales { get; set; }
        public decimal AverageInventory { get; set; }

        public decimal CalculateInventoryTurnover()
        {
            return Sales / AverageInventory;
        }
    }
}
