using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Controlls")]
    [SerializeField] Customer _customer;
    private CharacterController controller;
    public GameObject holding = null;
    [SerializeField] float xSens;
    [SerializeField] float ySens;
    
    [SerializeField] Transform orientation;

     float xRotation;
     float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        //controller.height = 5f;
        // controller.radius = 5f;
        // controller.center = new Vector3(5f, 5f, 5f);
        // controller.minMoveDistance = 5f;
        // controller.skinWidth = 5f;
        // controller.stepOffset = 5f;
        // controller.slopeLimit = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * xSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * ySens * Time.deltaTime;

        yRotation += mouseX;
        
        // Calculate the new x rotation and clamp it
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        // Apply rotation to the camera
        orientation.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
        if (Input.GetKeyDown("f"))
        {
            Drop();
        }
    
    }

    public bool hand_empty()
    {
        if (holding == null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public GameObject GetHolding()
    {
        return holding;
    }

    public void PickUp(GameObject item)
    {
        //if (holding == items.None)
        {
            holding = item;
            Debug.Log("You picked up " + item);
        }
        //else
        {
            Debug.Log("You are already holding something");
        }
    }
    public void Drop()
    {
        Debug.Log(holding + " was removed from your inventory");
        holding =  null;
    }
}
