using UnityEngine;

public class leaver : MonoBehaviour
{
    [SerializeField] CoffeMachine machine;
    private void OnMouseDown()
    {
        if (machine.in_space != null)
        {
            Debug.Log("Pushing");
            machine.push();
        }
    }
}
