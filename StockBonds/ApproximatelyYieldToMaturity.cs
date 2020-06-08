namespace StockBonds
{
    public class ApproximatelyYieldToMaturity
    {
        public decimal CouponOrInterestPayment { get; set; }
        public decimal FaceValue { get; set; }
        public decimal Price { get; set; }
        public decimal YearsToMaturity { get; set; }

        public decimal CalculateApproximatelyYieldToMaturity()
        {
            decimal numerator = CouponOrInterestPayment + ((FaceValue - Price) / YearsToMaturity);
            decimal denomirator = (FaceValue + Price) / 2;
            return numerator / denomirator;
        }
    }
}
