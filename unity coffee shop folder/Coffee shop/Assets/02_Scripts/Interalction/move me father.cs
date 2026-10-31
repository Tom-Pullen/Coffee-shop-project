using UnityEngine;

public class movemefather : MonoBehaviour
{
    [SerializeField] Vector3 position;
    [SerializeField] Quaternion rotation;
    [SerializeField] Transform player;

    void OnMouseDown()
    {
        //Debug.Log("It's hapening");
        player.position = position;
        player.rotation = rotation;
    }
}
