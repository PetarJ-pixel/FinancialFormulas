using System;

namespace StockBonds
{
    public class ZeroCouponBondValue
    {
        public decimal FaceValue { get; set; }
        public decimal RateOrYield { get; set; }
        public decimal TimeToMaturity { get; set; }

        public decimal CalculateZeroCouponBondValue()
        {
            return FaceValue / (decimal)Math.Pow((double)(1 + RateOrYield), (double)TimeToMaturity);
        }
    }
}
