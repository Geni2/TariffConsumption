
using TariffComparison;
using TariffComparison.Tariff;
using TariffComparison.Product;
using System.Collections;


Console.WriteLine("Please provide your annual consumption (kWh/year): ");
var consumption = Console.ReadLine();
int result;
//Check if the input is int or not
try
{   
    result = int.Parse(consumption);  
}
catch (FormatException)
{
    throw new ArgumentException($"{consumption} is not a valid integer.");
}
//Create the ascending list with tariff
SortedList sortList = new();

sortList.Add(new Tariff(new ProductBasicTariff(), result).getAnnualCosts(), new Tariff(new ProductBasicTariff(), result).tariffName());
sortList.Add(new Tariff(new ProductPackagedTariff(), result).getAnnualCosts(), new Tariff(new ProductPackagedTariff(), result).tariffName());

//Print all the element of the ascending list
foreach (DictionaryEntry element in sortList)
{   
    Console.WriteLine($"Tariff name: {element.Value}, Annual Costs: {element.Key} (\u20AC/year)");
}