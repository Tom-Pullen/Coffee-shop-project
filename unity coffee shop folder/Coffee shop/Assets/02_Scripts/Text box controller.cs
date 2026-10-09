using UnityEngine;
using UnityEngine.UI;

public class Textboxcontroller : MonoBehaviour
{
    [SerializeField] private string _contents;
    [SerializeField] private bool _writing = false;
    [SerializeField] private string _output = "";
    private int i = 0;
    [SerializeField] Text _textBox;
    [SerializeField] private float _keepTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (_writing)
        {
            if (_keepTime > 0.2f)
            {
                _textBox.text = _textBox.text + _contents[i];
                i++;
                _keepTime = 0;
            }
            else
            {
                _keepTime += Time.deltaTime;
            }
            if (_textBox.text == _contents)
            {
                _writing = false;
            }
        }
    }

    void write(string text)
    {
        _contents = text;
        _writing = true; 
    }
}
