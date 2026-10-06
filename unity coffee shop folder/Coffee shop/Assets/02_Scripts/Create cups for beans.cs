using UnityEngine;

public class Createcupsforbeans : MonoBehaviour
{
    [SerializeField] private GameObject coffeeCup;
    [SerializeField] int beans = 8; 
    void Start()
    {   
        while (beans != 0)
        {
            Instantiate(coffeeCup, new Vector3( Random.Range(-2.032f, 0.4f), 0.96953f, -0.98804f),  Quaternion.identity);
            beans--;
        }
    }
}
