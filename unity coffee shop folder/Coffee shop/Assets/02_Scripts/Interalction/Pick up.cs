using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public menue _item = menue.cup;
    [SerializeField] PlayerMovement player;
    public GameObject UI_element;
    [SerializeField] Pickup self;
    [SerializeField] Cofee coffee;
    [SerializeField] GameObject body;
    [SerializeField] GameObject coffeevisable;
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void OnMouseDown()
    {
        if(self.enabled== true)
        {
            //GetComponent<IClickable>
            player.PickUp(self);
        }
    }

    public void showCoffee()
    {
        coffeevisable.SetActive(true);
    }

    public void SetItem(menue newItem)
    {
        _item = newItem;
    }
    // Update is called once per frame
    public void add_ingrideient(_ingridients addition)
    {
        coffee.contents.Add(addition);
    }
    public void pickUp()
    {
            //Debug.Log("Hallo");
            UI_element.SetActive(true);
            body.SetActive(false);
    }

    public void place(Vector3 pos)
    {
        UI_element.SetActive(false);
        body.transform.position = pos;
        body.SetActive(true);
    }
}
