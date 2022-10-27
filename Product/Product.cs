using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparison.Product
{
    //Implement the interface when different calculation of the annual costs are made
    public interface IProduct
    {
        //This method return the name off the product
        String GetName();

        //This method is to define the annual costs by using a specific calculation and return the annual costs
        double CalculationModel(int consumption);
    }
}
