using System;
using System.Collections;

namespace StockBonds
{
    public class GeometricMeanReturn
    {
        public decimal CalculateGeometricMeanReturn(ICollection ratesOfReturn)
        {
            int numberOfPeriods = ratesOfReturn.Count;
            decimal root = 1;
            foreach (decimal rateOfReturn in ratesOfReturn)
            {
                root *= 1 + rateOfReturn;
            }
            if (numberOfPeriods > 0)
            {
                return (decimal)Math.Pow((double)root, (double)decimal.Divide(1, numberOfPeriods)) - 1;
            }
            return 0;
        }
    }
}
