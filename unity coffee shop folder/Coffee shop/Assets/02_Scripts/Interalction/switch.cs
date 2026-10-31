using UnityEngine;

public class Switch : MonoBehaviour
{ 
    bool flip = false;
    [SerializeField] Animator vsMath;
    private void OnMouseDown()
    {
        flip = !flip;
        if (flip == false)
        {
            vsMath.SetTrigger("Up");
        }
        if (flip == true)
        {
            vsMath.SetTrigger("Down");
        }
        //Debug.Log(flip);    
    }

    public bool GetFlip()
    {
        return flip;
    }
}
