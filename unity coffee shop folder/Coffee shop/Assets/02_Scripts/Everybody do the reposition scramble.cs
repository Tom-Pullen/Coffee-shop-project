using UnityEngine;

public class Everybodydotherepositionscramble : MonoBehaviour
{
    //[SerializeField] private collider coffeeCup; 
    [SerializeField] private Transform self;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionStay(Collision collision)
    {
        self.position = new Vector3 (Random.Range(-2.032f, 0.4f), self.position.y, self.position.z);
    }
}
