using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Product
{
    public class ProductBasicTariff : IProduct
    {
        public String GetName() {
            return "basic electricity tariff";
        }

        public double CalculationModel(int consumption) 
        {
            consumption = consumption > 0 ? consumption : 0;
            double baseCostsYearly = 60;
            double consumptionCosts = consumption * 0.22;
            return baseCostsYearly + consumptionCosts;
        }
    }
}
