using System;
using System.Collections.Generic;

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

            while (number != 1)
            {
                var divisor = LeastCommonDivisor(number);
                number = number / divisor;
                yield return divisor;
            }
        }

        private static int LeastCommonDivisor(int number)
        {
            int divisor = 2;
            while (number % divisor != 0)
            {
                divisor++;
            }
            return divisor;
        }
    }
}
