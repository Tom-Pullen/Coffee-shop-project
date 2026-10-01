using UnityEngine;

public class Cofee : MonoBehaviour
{
    [SerializeField] PlayerMovement player; //registers the player
    [SerializeField] Pickup self; //registers the script responcible for picking itself up
    int _sugars = 0; //sets the number of sugars in a coffee to be 0 by default
    bool _milk = false; //set there to be no milk in a coffee by default
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown() //detects when the coffee is clicked
    {
       if (player.GetHolding() == "milk") //see's if the player is holding milk
       {
            Debug.Log("Milk added to coffee"); //lets the player no they added milk to the coffee
            _milk = true; //saves the fact that it contains milk
            player.Drop(); //removes milk from the players hand
       }
       if (player.GetHolding() == "sugar") //sees if the player is holding sugar
       {
            Debug.Log("One sugar added to cofee"); //lets player know they've added sugar to coffee
            _sugars++; //increase the number of sugars held by one
            player.Drop(); //removes sugar from the players hand
       }
       if (_milk && _sugars > 0) //sees if the coffee both contains milk, and sugar
        {
            self.SetItem("coffee with milk and " + _sugars + " sugars"); //changes the handle other scripts identify the coffee by to mention that it contains milk and sugar, along with how much milk 
        }
        else if (_milk) //if it doesn't contain both coffee and milk, it sees if it just contains milk
        {
            self.SetItem("coffee with milk"); //sets the handle to coffee with milk
        }
        else if (_sugars > 0) //if the coffee also doesn't contain milk, it checks if it contains just sugar
        {
            self.SetItem("coffee with " + _sugars + " sugars"); //sets the handle to the number of suggars it contains
        }

    }
}
