using UnityEngine;

public enum  CoffeeType{Escpresso, Latte, Cappuccino, Americano}

[CreateAssetMenu(fileName = "CoffeeData", menuName = "Coffee/Coffee Data")]
public class coffeeData : ScriptableObject
{
    public float escpressoPrice =2.0f;
    public float lattePrice = 3.5f;
    public float cappuccinoPrice = 3f;
    public float americanoPrice = 2.5f;
}
