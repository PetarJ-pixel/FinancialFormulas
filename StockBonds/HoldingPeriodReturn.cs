using System;
using System.Collections;

namespace StockBonds
{
    public class HoldingPeriodReturn
    {
        public decimal PeriodicRate { get; set; }
        public decimal NumberOfPeriods { get; set; }

        public decimal CalculateHoldingPeriodReturn(ICollection percentagePeriodReturn)
        {
            int numberOfPeriods = percentagePeriodReturn.Count;
            decimal a = 1;
            foreach (decimal period in percentagePeriodReturn)
            {
                a *= (1 + period);
            }
            if (numberOfPeriods > 0)
            {
                return a - 1;
            }
            return 0;
        }
        public decimal CalculateHoldingPeriodReturn()
        {
            return (decimal)Math.Pow((double)(1 + PeriodicRate), (double)NumberOfPeriods) - 1;
        }
    }
}
