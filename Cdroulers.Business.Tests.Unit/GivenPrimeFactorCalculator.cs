using System;
using NUnit.Framework;

namespace Cdroulers.Business.Tests.Unit
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class GivenPrimeFactorCalculator
    {
        private PrimeFactorCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new PrimeFactorCalculator();
        }

        [Test]
        public void When_calculating_prime_factors_for_zero_Then_throws_argument_out_of_range_exception()
        {
            Assert.That(() => _calculator.CalculatePrimeFactors(0), Throws.Exception.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void When_calculating_prime_factors_for_one_Then_returns_one()
        {
            Assert.That(_calculator.CalculatePrimeFactors(1), Is.EquivalentTo(new[] { 1 }));
        }
    }
}
