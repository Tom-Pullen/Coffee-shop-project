using UnityEngine;

public class leaver : MonoBehaviour
{
    [SerializeField] CoffeMachine machine;
    private void OnMouseDown()
    {
        if (machine.in_space != null)
        {
            if (machine.in_space._item == menue.cup)
            {
                //Debug.Log("Pushing");
                machine.push();
            }
        }
    }
}
