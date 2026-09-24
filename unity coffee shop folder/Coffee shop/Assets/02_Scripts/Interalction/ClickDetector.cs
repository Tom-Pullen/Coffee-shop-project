using UnityEngine;

public class ClickDetector : MonoBehaviour
{
    [SerializeField] private int _alan = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        //GetComponent<IClickable>
        _alan++;
        Debug.Log(_alan);
    }
}
