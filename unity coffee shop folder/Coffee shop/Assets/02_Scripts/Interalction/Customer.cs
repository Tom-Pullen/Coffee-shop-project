using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public string drinkType;
    public UnityEvent raiseOrder;
    [SerializeField] PlayerMovement player;
    [SerializeField] Text _textBox;
    //public struct Random Random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int ran = Random.Range(0,3); //choses a rando number between 0 and 3
        //order plane coffee
        if (ran == 0)
        {
            drinkType = "coffee"; 
        }
        //order coffe with milk no suggar
        else if (ran == 1)
        {
            drinkType = "coffee with milk";
        }
        //order coffee with 1-4 sugars, no milk
        else if (ran == 2)
        {
            drinkType = "coffee with " + Random.Range(1,4) + " sugars"; 
        }
        //order coffee with 1-4 sugars and milk
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
            _textBox.text = "Can I get a " + type;
            //Debug.Log("Can I get a " + type);
        }
        else
        {
            player.Drop();
            _textBox.text = "Thanks";
            //Debug.Log("Thanks");
        }
        raiseOrder?.Invoke();
    }
}
