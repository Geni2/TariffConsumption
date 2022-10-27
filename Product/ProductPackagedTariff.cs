using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Product
{
    public class ProductPackagedTariff : IProduct
    {
        public String GetName()
        {
            return "Packaged tariff";
        }

        public double CalculationModel(int consumption)
        {
            //TODO magic numbers
            double additionalCosts = 0;
            int additionalConsumption = consumption - 4000;
            if (additionalConsumption > 0)
                additionalCosts = additionalConsumption * 0.3;
            return 800 + additionalCosts;
        }
    }
}
