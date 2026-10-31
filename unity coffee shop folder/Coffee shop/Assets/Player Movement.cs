using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Controlls")]
    [SerializeField] Customer _customer;
    private CharacterController controller;
    public Pickup holding = null;
    
    [Header("Camera Move")]
    [SerializeField] float xSens;
    [SerializeField] float ySens;
    
    [SerializeField] Transform orientation;

     float xRotation;
     float yRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
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
    public Pickup GetHolding()
    {
        return holding;
    }

    public void PickUp(Pickup item)
    {
        if (hand_empty())
        {
            holding = item;
            item.pickUp();
        }
    }
    public void Drop()
    {
        Debug.Log(holding + " was removed from your inventory");
        holding =  null;
    }
}
