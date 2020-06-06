namespace CorporateFormula
{
    public class CurrentRatio
    {
        public decimal CurrentAssets { get; set; }
        public decimal CurrentLiabilities { get; set; }

        public decimal CalculateCurrentRatio()
        {
            return CurrentAssets / CurrentLiabilities;
        }
    }
}
