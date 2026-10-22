using UnityEngine;
using System.Collections.Generic;


public class Cofee : MonoBehaviour
{
    [SerializeField] PlayerMovement player; //registers the player
    [SerializeField] Pickup self; //registers the script responcible for picking itself up
    [SerializeField] List<_ingridients> contents = new List<_ingridients>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown() //detects when the coffee is clicked
    {
       if (player.GetHolding().tag == "milk") //see's if the player is holding milk
       {
            Debug.Log("Milk added to coffee"); //lets the player no they added milk to the coffee
            contents.Add(_ingridients.milk);
            player.Drop(); //removes milk from the players hand
       }
       if (player.GetHolding().tag == "sugar") //sees if the player is holding sugar
       {
            Debug.Log("One sugar added to cofee"); //lets player know they've added sugar to coffee
            contents.Add(_ingridients.sugar); //increase the number of sugars held by one
            player.Drop(); //removes sugar from the players hand
       }
       
       //if contains ingridents x y z, set coffee type to capachino, escpresso, excetera


    }
}
