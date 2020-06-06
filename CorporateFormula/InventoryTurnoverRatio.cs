namespace CorporateFormula
{
    public class InventoryTurnoverRatio
    {
        public decimal Sales { get; set; }
        public decimal Inventory { get; set; }

        public decimal CalculateInventoryTurnoverRatio()
        {
            return Sales / Inventory;
        }
    }
}
