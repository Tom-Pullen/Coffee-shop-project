using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public readonly static string drinkType = "coffee"; //static means that it is per class and not per instance of class (object)
    public UnityEvent raiseOrder;
    [SerializeField] PlayerMovement player;
    public struct Random Random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Random.Range(1,0));
    }
   private void OnMouseDown()
   {
        RequestDrinkType(drinkType);
   }
    public void RequestDrinkType(string type)
    {
        //Debug.Log("She met her on the tiltawhirl");
        if (player.GetHolding() != drinkType)
        {
            Debug.Log("Can I get a " + type);
        }
        else
        {
            player.Drop();
            Debug.Log("Thanks");
        }
        raiseOrder?.Invoke();
    }
}
