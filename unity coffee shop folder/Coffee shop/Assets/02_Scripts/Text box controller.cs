using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Textboxcontroller : MonoBehaviour
{
    [SerializeField] Text _textBox;
    private float _time = 0.05f;

    // Update is called once per frame
    void Start()
    {
    }

    public IEnumerator Output(string comeAndPrintMe)
    {

        _textBox.text = "";
        foreach (char letter in comeAndPrintMe)
        {
            _textBox.text = _textBox.text + letter;
            yield return new WaitForSeconds(_time);
            if (Input.GetKeyDown("e"))
            {
                _textBox.text = comeAndPrintMe;
                break;
            }
        }
        if (Input.GetKeyDown("e"))
        {
            //_textBox.enable
        }
    }
    public void Write (string iWannaWriteWithSomebody)
    {
        StartCoroutine(Output(iWannaWriteWithSomebody));
    }
}
