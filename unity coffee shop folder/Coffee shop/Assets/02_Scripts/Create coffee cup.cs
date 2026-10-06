using UnityEngine;

public class Createcoffeecup : MonoBehaviour
{
    [SerializeField] private GameObject coffeeCup; 
    void Start()
    {   
        for (int i = 0; i<10; i++)
        {
            Instantiate(coffeeCup, new Vector3( Random.Range(-2.032f, 0.4f), 0.96953f, -0.98804f),  Quaternion.identity);
        }
    }
}
