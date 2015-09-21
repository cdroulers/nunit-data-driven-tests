using System.Collections.Generic;
using System.IO;
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
            // Naive implementation of a TSV file reader.
            using (var reader = new StreamReader(FileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Skip header.
                    if (line.StartsWith("Number"))
                    {
                        continue;
                    }

                    var parts = line.Split('\t');
                    var factors = parts[1].Split(',').Select(int.Parse).ToArray();
                    yield return new PrimeFactorTestCase(int.Parse(parts[0]), factors);
                }
            }
        }
    }
}
