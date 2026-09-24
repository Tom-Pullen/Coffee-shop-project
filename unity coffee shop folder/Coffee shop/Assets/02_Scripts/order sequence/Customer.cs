using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public readonly static string drinkType = "coffee"; //static means that it is per class and not per instance of class (object)
    public UnityEvent raiseOrder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        RequestDrinkType(drinkType);
    }
    
    public void RequestDrinkType(string type)
    {
        Debug.Log("She met her on the tiltawhirl");
        Debug.Log(type);

        raiseOrder?.Invoke();
    }
}
