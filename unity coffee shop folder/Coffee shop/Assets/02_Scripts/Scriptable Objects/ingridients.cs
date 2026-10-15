using UnityEngine;

public enum allergies{dairy, gluten, nuts, bananas, havingTheirThroatSlit, mangoes}
[CreateAssetMenu(fileName = "ingridients", menuName = "ingridients")]
public class ingridients : ScriptableObject
{
    public float price;
    public int  quantity;
    public allergies allergies;
}
