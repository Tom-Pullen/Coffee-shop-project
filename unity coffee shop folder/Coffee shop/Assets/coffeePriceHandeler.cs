using UnityEngine;

public class coffeePriceHandeler : MonoBehaviour
{
    [SerializeField] coffeeData _coffeeData;
    [SerializeField] CoffeeType _selectedCoffee;

    private void Start()
    {
        float price = GetCoffeePrice(_selectedCoffee);
        Debug.Log($"{_selectedCoffee} costs £{price:F2}");
    }
    private float GetCoffeePrice(CoffeeType type)
    {
        switch (type)
        {
            case CoffeeType.Escpresso:
                return _coffeeData.escpressoPrice;
            
            case CoffeeType.Latte:
                return _coffeeData.lattePrice;

            case CoffeeType.Cappuccino:
                return _coffeeData.cappuccinoPrice;

            case CoffeeType.Americano:
                return _coffeeData.americanoPrice;

            default:
                return 0f;
        }
    }
}
