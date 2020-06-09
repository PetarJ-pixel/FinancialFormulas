namespace Financial
{
    public class GrossProfit
    {
        public decimal Revenue { get; set; }
        public decimal CostOfGoodsSold { get; set; }

        public decimal CalculateGrossProfit()
        {
            return Revenue - CostOfGoodsSold;
        }
    }
}
