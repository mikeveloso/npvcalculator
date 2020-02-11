using System.Threading.Tasks;

using NpvCalculator.Models;

namespace NpvCalculator.Repositories
{
    public class NpvRepository : INpvRepository
    {
        public readonly INpvCalculator npvCalculator;

        public NpvRepository(INpvCalculator calculator) => npvCalculator = calculator;

        public Npv CalculateNetPresentValue(Npv npv)
        {
            npv = npvCalculator.CalculateNetPresentValue(npv);

            return npv;
        }
    }
}
