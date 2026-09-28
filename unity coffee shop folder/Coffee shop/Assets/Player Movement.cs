using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Controlls")]
    [SerializeField]
    private CharacterController controller;
    //movement conttrolls
    void Start()
    {
        controller.height = 5f;
        controller.radius = 5f;
        controller.center = new Vector3(5f, 5f, 5f);
        controller.minMoveDistance = 5f;
        controller.skinWidth = 5f;
        controller.stepOffset = 5f;
        controller.slopeLimit = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogError("Hollywood infected your brain");
        Debug.LogWarning("You wanted kissing in the rain");
        
        
    }
}
