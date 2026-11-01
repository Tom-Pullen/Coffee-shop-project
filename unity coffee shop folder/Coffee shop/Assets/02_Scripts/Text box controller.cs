using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Textboxcontroller : MonoBehaviour
{
    [SerializeField] Text _textBox;
    [SerializeField] GameObject box;
    [SerializeField] AudioSource mm;
    private bool _printing;
    private float _time = 0.05f;
    [SerializeField] List<string> to_be_writen = new List<string>();
    [SerializeField] List<Color> new_color = new List<Color>();
    int pointer = 0;
    bool skip = false;
    bool skipable = false;

    // Update is called once per frame
    void Update()
    {
        if (to_be_writen.Count > pointer && !_printing) //checks if there are still things in the list that aren't writen and aren't being writen
        {
            if (!(_textBox.text == "")) //checks that the text box isn't empty
            {
                if (Input.GetKeyDown("e")) 
                {
                    StartCoroutine(Output(to_be_writen[pointer], new_color[pointer])); //starts the printing proccess
                    pointer++; //increments the pointer
                }
            }
            else
            {
                StartCoroutine(Output(to_be_writen[pointer], new_color[pointer])); //starts the printing proccess
                pointer++; //increments the pointer
            }
        }
        if (Input.GetKeyDown("e") && !_printing) 
        {
            _textBox.text = ""; //resets the contents of the text box
            box.SetActive(false); //deactivates the contents
            _printing = false; //ensures 
        }
        if (Input.GetKeyDown("e") && skipable)
        {
            skip = true;
        }
    }

    public IEnumerator Output(string comeAndPrintMe, Color c)
    {
       
        box.SetActive(true); //makes the text box vissable
        skip = false; 
        _printing = true; 
        _textBox.color = c; //changes the color of the text box 
        _textBox.text = ""; //clears the contents of the text box
        skipable = true;
        foreach (char letter in comeAndPrintMe) 
        {   
            if (skip == true)
            {
                Debug.Log("skipping");
                _textBox.text = comeAndPrintMe;
                skip = false;
                skipable = false;
                break;
            }
            else
            {
                _textBox.text = _textBox.text + letter;
                if (letter != " "[0])
                {
                    yield return new WaitForSeconds(_time);
                    mm.Play();
                }
            }

        }
        skipable = false;
        _printing = false;
        
        
    }
    public void Write (string iWannaWriteWithSomebody, Color collor)
    {
        to_be_writen.Add(iWannaWriteWithSomebody);
        new_color.Add(collor);
    }
}
