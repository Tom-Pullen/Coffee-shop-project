using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int coffeesSold = 0;
    public float coffeePrice = 3.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Coffees sold: " + coffeesSold);
        coffeesSold++;
        Debug.Log("Coffees sold: " + coffeesSold);
        coffeesSold *= 5;

    }

    void AddCoffee()
    {
        coffeesSold =+1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
