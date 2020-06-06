namespace CorporateFormula
{
    public class DaysInInventory
    {
        public decimal InventoryTurnover { get; set; }

        public decimal CalculateDaysInInventory()
        {
            return 365 / InventoryTurnover;
        }
    }
}
