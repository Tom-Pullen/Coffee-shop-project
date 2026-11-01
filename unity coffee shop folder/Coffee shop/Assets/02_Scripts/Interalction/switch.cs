using UnityEngine;

public class Switch : MonoBehaviour
{ 
    bool flip = false;
    [SerializeField] Animator vsMath;
    [SerializeField] AudioSource click_sound;
    private void OnMouseDown()
    {
        flip = !flip;
        click_sound.Play();
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
