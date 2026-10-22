using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public enum menue {escpresso, americano, capachino, blackCoffee, flatWhite, cup, None}
public enum _ingridients {sugar, milk, escpresso}

public class Customer : MonoBehaviour
{
    
    public menue drinkType;
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
                drinkType = menue.escpresso;
                break;
            }
            case 1:
            {
                drinkType = menue.americano;
                break;
            }
            case 2:
            {
                drinkType = menue.capachino;
                break;
            }
            case 3:
            {
                drinkType = menue.blackCoffee;
                break;
            }
            case 4:
            {
                drinkType = menue.flatWhite;
                break;
            }
        }
    }
   private void OnMouseDown()
   {
        RequestDrinkType(drinkType);
   }
    public void RequestDrinkType(menue type)
    {
        if (new_customer)
        {
            _textBox.Write("Welcome to the noisy rythm, what can I get you?", new Color(238, 89, 230, 230));
            new_customer = false;
        }
        //Debug.Log("She met her on the tiltawhirl");
        if (player.hand_empty() == true)
        {
            switch (type)
            {
                case menue.escpresso:
                {
                    _textBox.Write("Can I get an espresso", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.americano:
                {
                    _textBox.Write("Can I get an americano", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.capachino:
                {
                    _textBox.Write("Can I get a cappuccino", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.blackCoffee:
                {
                    _textBox.Write("Can I get a black coffee", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.flatWhite:
                {
                    _textBox.Write("Can I get a flat white", new Color(255, 120, 0, 230));
                    break;
                }
            }
        }
        else if (player.GetHolding().tag != "" + type)
        {
            switch (type)
            {
                case menue.escpresso:
                {
                    _textBox.Write("Can I get an espresso", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.americano:
                {
                    _textBox.Write("Can I get an americano", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.capachino:
                {
                    _textBox.Write("Can I get a cappuccino", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.blackCoffee:
                {
                    _textBox.Write("Can I get a black coffee", new Color(255, 120, 0, 230));
                    break;
                }
                case menue.flatWhite:
                {
                    _textBox.Write("Can I get a flat white", new Color(255, 120, 0, 230));
                    break;
                }
            }           
        }
        else
        {
            player.Drop();
            _textBox.Write("Thanks", new Color(255, 120, 0, 230));
            //Debug.Log("Thanks");
            int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
            {
                drinkType = menue.escpresso;
                break;
            }
            case 1:
            {
                drinkType = menue.americano;
                break;
            }
            case 2:
            {
                drinkType = menue.capachino;
                break;
            }
            case 3:
            {
                drinkType = menue.blackCoffee;
                break;
            }
            case 4:
            {
                drinkType = menue.flatWhite;
                break;
            }
        }
        }
        raiseOrder?.Invoke();
    }

}
