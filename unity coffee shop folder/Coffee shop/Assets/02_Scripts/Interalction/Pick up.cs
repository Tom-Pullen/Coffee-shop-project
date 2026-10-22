using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] menue _item = menue.cup;
    [SerializeField] PlayerMovement player;
    [SerializeField] GameObject self;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        //GetComponent<IClickable>
        player.PickUp(self);
    }

    public void SetItem(menue newItem)
    {
        _item = newItem;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
