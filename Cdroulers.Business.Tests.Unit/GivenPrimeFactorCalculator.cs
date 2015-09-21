using System;
using System.Collections.Generic;
using Cdroulers.Business.Tests.Unit.Data;
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
        public void When_calculating_prime_factors_for_one_Then_returns_empty_list()
        {
            Assert.That(_calculator.CalculatePrimeFactors(1), Is.Empty);
        }

        [Test]
        public void When_calculating_prime_factors_for_two_Then_returns_list_with_element_two()
        {
            Assert.That(_calculator.CalculatePrimeFactors(2), Is.EquivalentTo(new[] { 2 }));
        }

        [TestCaseSource("ReadPrimeFactorTestCases")]
        public void When_calculating_prime_factors_Then_returns_proper_list_of_factors(PrimeFactorTestCase testCase)
        {
            var actual = _calculator.CalculatePrimeFactors(testCase.Number);
            Assert.That(actual, Is.EquivalentTo(testCase.PrimeFactors));
        }

        private static IEnumerable<PrimeFactorTestCase> ReadPrimeFactorTestCases()
        {
            var reader = new PrimeFactorTestCaseReader("Data/prime-factors.tsv");
            return reader.ReadTestCases();
        }
    }
}
