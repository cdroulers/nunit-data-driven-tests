using System.Diagnostics;

namespace Cdroulers.Business.Tests.Unit.Data
{
    [DebuggerDisplay("PrimeFactorTestCase {ToString()}")]
    public class PrimeFactorTestCase
    {
        public readonly int Number;

        public readonly int[] PrimeFactors;

        public PrimeFactorTestCase(int number, int[] primeFactors)
        {
            Number = number;
            PrimeFactors = primeFactors;
        }

        public override string ToString()
        {
            return string.Format("Number: {0}, PrimeFactors: {1}", Number, string.Join(", ", PrimeFactors));
        }
    }
}
