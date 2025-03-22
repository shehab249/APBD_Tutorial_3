using Tutorial_3.Enums;

namespace Tutorial_3;

public class TemperatureValidator
{
    public static bool IsValid(ProductType productType, double currentTemperature)
    {
        var allowedTemperature = GetTemperature(productType);
        return currentTemperature >= allowedTemperature;
    }

    public static double GetTemperature(ProductType productType)
    {
        var temperature = productType switch
        {
            ProductType.Bananas => 13.3,
            ProductType.Chocolate => 18,
            ProductType.Meat => -15,
            ProductType.Fish => 2,
            ProductType.IceCream => 18,
            ProductType.FrozenPizza => -30,
            ProductType.Cheese => 7.2,
            ProductType.Sausages => 5,
            ProductType.Butter => 20.5,
            ProductType.Eggs => 19,
            ProductType.Milk => 4,
            ProductType.Bread => 25,
            _ => throw new ArgumentException("Invalid product type")
        };
        return temperature;
    }
}