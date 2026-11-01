using UnityEngine;

public class Playmusic : MonoBehaviour
{
    [SerializeField] AudioSource music;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        music.Play();
    }
}
