using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections;

using TariffComparison.Product;

namespace TariffComparison.Tariff
{
    public class Tariff
    {

       private string name;
       private double annualCosts;
        
        public Tariff(IProduct product, int consumption) {
            name = product.GetName();
            annualCosts = product.CalculationModel(consumption);
        }
        
        public double  getAnnualCosts() {
            return annualCosts;
        }

        public String tariffName()
        {
            return name;
        }

    }
}
