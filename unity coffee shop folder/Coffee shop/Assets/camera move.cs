using UnityEngine;

public class cameramove : MonoBehaviour
{
    [SerializeField] Transform cameraPosition;
    [SerializeField] Transform targetPosition;
    // Update is called once per frame
    void Update()
    {
        cameraPosition.position = targetPosition.position;
    }
}
