using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public string drinkType;
    public UnityEvent raiseOrder;
    [SerializeField] PlayerMovement player;
    //public struct Random Random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int ran = Random.Range(0,3);
        if (ran == 0)
        {
            drinkType = "coffee";
        }
        else if (ran == 1)
        {
            drinkType = "coffee with milk";
        }
        else if (ran == 2)
        {
            ran = Random.Range(1,4);
            drinkType = "coffee with " + Random.Range(1,4) + " sugars";
        }
       else if (ran == 3)
        {
            drinkType = "coffee with milk and " + Random.Range(1,4) + " sugars";
        }

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
