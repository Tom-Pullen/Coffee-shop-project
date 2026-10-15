using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] items _item = items.cup;
    [SerializeField] PlayerMovement player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        //GetComponent<IClickable>
        player.PickUp(_item);
    }

    public void SetItem(items newItem)
    {
        _item = newItem;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
