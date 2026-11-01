using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoffeMachine : MonoBehaviour
{
    [SerializeField] PlayerMovement player;
    public Pickup in_space;
    [SerializeField] Switch switch_1;
    [SerializeField] Switch switch_2;
    [SerializeField] Switch switch_3;
    [SerializeField] Transform tp;
    [SerializeField] Animator vsAnitmation;
    [SerializeField] AudioSource bloop;
    private string code = "falsefalsefalse";
    menue typeBeingmade = menue.blackCoffee;

    void Update()
    {
        if (Input.GetKeyDown("u"))
        {
            Debug.Log(switch_1.GetFlip() + "" + switch_2.GetFlip() + switch_3.GetFlip());
        }
    }

    private void OnMouseDown()
    {
        //Debug.Log("Hallo, how are youuuuuu");
        //takes
        if ((player.hand_empty()) == false)
        {
            if(player.holding._item == menue.cup)
            {
                in_space = player.GetHolding();
                player.Drop();
                in_space.place(tp.position);
            }
        }
    }

    public void push()
    {
        code = "" + switch_1.GetFlip() + switch_2.GetFlip() + switch_3.GetFlip();
        switch (code)
        {
            case "FalseFalseFalse":
            {
                typeBeingmade = menue.blackCoffee;
                break;
            }
            case "TrueFalseFalse":
            {
                typeBeingmade = menue.escpresso;
                break;
            }
            case "FalseTrueFalse":
            {
                typeBeingmade = menue.flatWhite;
                break;
            }
            case "TrueTrueFalse":
            {
                typeBeingmade = menue.americano;
                break;
            }
            case "FalseFalseTrue":
            {
                typeBeingmade = menue.capachino;
                break;
            }
            case "TrueFalseTrue":
            {
                typeBeingmade = menue.latte;
                break;
            }
            case "FalseTrueTrue":
            {
                typeBeingmade = menue.mocha;
                break;
            }
            case "TrueTrueTrue":
            {
                typeBeingmade = menue.macchiato;
                break;
            }

        }
        Debug.Log(typeBeingmade);
        StartCoroutine(MakeCoffee());

    }
    IEnumerator MakeCoffee()
    {
        in_space.enabled = false; //disables the ability to pick up the coffee
        vsAnitmation.SetTrigger("go"); //starts the animation
        bloop.Play();//plays the sound effect
        yield return new WaitForSeconds(1.2f); //waits until the animation is complete
        in_space.showCoffee(); //shows the coffee texture
        in_space._item = typeBeingmade;
        in_space.enabled = true; //makes it possible to pick up the coffee again 
    } 
}
