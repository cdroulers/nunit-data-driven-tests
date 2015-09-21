using System.Collections.Generic;
using System.Linq;

namespace Cdroulers.Business.Tests.Unit.Data
{
    public class PrimeFactorTestCaseReader
    {
        public readonly string FileName;

        public PrimeFactorTestCaseReader(string fileName)
        {
            FileName = fileName;
        }

        public IEnumerable<PrimeFactorTestCase> ReadTestCases()
        {
            return Enumerable.Empty<PrimeFactorTestCase>();
        }
    }
}
