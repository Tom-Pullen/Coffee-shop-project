using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public enum items {escpresso, americano, capachino, blackCoffee, flatWhite, sugar, milk, cup, None}

public class Customer : MonoBehaviour
{
    
    public items drinkType;
    public UnityEvent raiseOrder;
    [SerializeField] PlayerMovement player;
    [SerializeField] Textboxcontroller _textBox;
    bool new_customer = true;
    //public struct Random Random;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
            {
                drinkType = items.escpresso;
                break;
            }
            case 1:
            {
                drinkType = items.americano;
                break;
            }
            case 2:
            {
                drinkType = items.capachino;
                break;
            }
            case 3:
            {
                drinkType = items.blackCoffee;
                break;
            }
            case 4:
            {
                drinkType = items.flatWhite;
                break;
            }
        }
    }
   private void OnMouseDown()
   {
        RequestDrinkType(drinkType);
   }
    public void RequestDrinkType(items type)
    {
        if (new_customer)
        {
            _textBox.Write("Welcome to the noisy rythm, what can I get you?");
            new_customer = false;
        }
        //Debug.Log("She met her on the tiltawhirl");
        if (player.GetHolding() != type)
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
