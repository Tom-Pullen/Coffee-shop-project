using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Customer : MonoBehaviour
{
    public string drinkType;
    public UnityEvent raiseOrder;
    [SerializeField] PlayerMovement player;
    [SerializeField] Textboxcontroller _textBox;
    [SerializeField] string[] menue;
    //public struct Random Random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        drinkType = menue[Random.Range(0,menue.Length)]; //choses a random number between 0 and 3
        //order plane coffee
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
            _textBox.Write("Can I get a " + type);
            //Debug.Log("Can I get a " + type);
        }
        else
        {
            player.Drop();
            _textBox.Write("Thanks");
            //Debug.Log("Thanks");
        }
        raiseOrder?.Invoke();
    }
}
