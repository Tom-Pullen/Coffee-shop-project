using UnityEngine;

public class Cofee : MonoBehaviour
{
    [SerializeField] PlayerMovement player;
    [SerializeField] Pickup self;
    int _sugars = 0;
    bool _milk = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
       if (player.GetHolding() == "milk")
       {
            Debug.Log("Milk added to coffee");
            self.SetItem("Coffee with milk");
            _milk = true;
            player.Drop();
       }
       if (player.GetHolding() == "sugar")
       {
            Debug.Log("One sugar added to cofee");
            _sugars++;
            player.Drop();
       }
       if (_milk && _sugars > 0)
        {
            self.SetItem("Coffee with milk and " + _sugars + " sugars");
        }
        else if (_milk)
        {
            self.SetItem("Coffee with milk");
        }
        else if (_sugars > 0)
        {
            self.SetItem("Coffee with " + _sugars + " sugars");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
