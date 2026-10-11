using UnityEngine;
using UnityEngine.UI;

public class Textboxcontroller : MonoBehaviour
{
    private string _contents;
    private bool _writing = false;
    private int i = 0;
    [SerializeField] Text _textBox;
    private float _keepTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (_writing) //sees if it should be writing
        {
            if (_keepTime > 0.05f) //determins how long to wait between characters
            {
                if (_contents[i] == " "[0])
                {
                    _textBox.text = _textBox.text + _contents[i];
                    i++;    
                }
                _textBox.text = _textBox.text + _contents[i]; //updates the text box with the new contents
                i++; //increments the character to be added
                _keepTime = 0; //resets the timer
            }
            else
            {
                _keepTime += Time.deltaTime; //keeps time between characters added
            }
            if (_textBox.text == _contents) //checks if all the text is now displayed
            {
                _writing = false; //stops the program from trying to keep writng
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("me and my girls");
        }
    }

    public void write(string text)
    {
        _contents = text; // sets the text to be writen
        _writing = true; //tells the program to start writing
        i = 0;
        _textBox.text = "";
    }
}
