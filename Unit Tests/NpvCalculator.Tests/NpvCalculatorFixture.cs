using System;

using NpvCalculator.Repositories;

namespace NpvCalculator.Tests
{
    public class NpvCalculatorFixture : IDisposable
    {
        public NpvRepository CalculatorRepository { get; }

        public NpvCalculatorFixture()
        {
            CalculatorRepository = new NpvRepository(new NpvCalculator());
        }

        public void Dispose()
        {   
        }
    }

}
