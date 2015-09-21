using System;
using System.Collections.Generic;
using System.Linq;

namespace Cdroulers.Business
{
    public class PrimeFactorCalculator
    {
        public IEnumerable<int> CalculatePrimeFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("number", "Cannot calculate prime factors for zero or negative numbers.");
            }

            if (number == 1)
            {
                return Enumerable.Empty<int>();
            }

            return new[] { number };
        }
    }
}
