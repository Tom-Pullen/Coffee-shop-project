using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Textboxcontroller : MonoBehaviour
{
    [SerializeField] Text _textBox;
    [SerializeField] GameObject box; 
    private bool _printing;
    private float _time = 0.05f;
    [SerializeField] List<string> to_be_writen = new List<string>();
    [SerializeField] List<Color> new_color = new List<Color>();
    int pointer = 0;

    // Update is called once per frame
    void Update()
    {
        if (to_be_writen.Count > pointer && !_printing)
        {
            if (!(_textBox.text == ""))
            {
                if (Input.GetKeyDown("e"))
                {
                    StartCoroutine(Output(to_be_writen[pointer], new_color[pointer]));
                    pointer++;
                }
            }
            else
            {
                StartCoroutine(Output(to_be_writen[pointer], new_color[pointer]));
                pointer++;
            }
        }
        if (Input.GetKeyDown("e") && !_printing)
        {
            _textBox.text = "";
            box.SetActive(false);
        }
    }

    public IEnumerator Output(string comeAndPrintMe, Color c)
    {
        box.SetActive(true);
        _printing = true;
        _textBox.color = c;
        _textBox.text = "";
        foreach (char letter in comeAndPrintMe)
        {
            if ((letter + "").ToUpper() == (letter + "") && _textBox.text != "")
            {
                _textBox.text = _textBox.text + " ";    
            }
            _textBox.text = _textBox.text + letter;
            if (letter != " "[0])
            {
                yield return new WaitForSeconds(_time);
            }
            if (Input.GetKey("e"))
            {
                _textBox.text = comeAndPrintMe;
                break;
            }
        }
        _printing = false;
    }
    public void Write (string iWannaWriteWithSomebody, Color collor)
    {
        to_be_writen.Add(iWannaWriteWithSomebody);
        new_color.Add(collor);
    }
}
