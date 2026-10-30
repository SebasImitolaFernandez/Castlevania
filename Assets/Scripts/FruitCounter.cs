using UnityEngine;
using TMPro;
public class FruitCounter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static FruitCounter instance;

    public TextMeshProUGUI text;   // arrastra aquí el texto del Canvas
    int count = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateText();
    }

    public void AddFruit()
    {
        count++;
        UpdateText();
    }

    void UpdateText()
    {
        text.text = "Frutas: " + count;
    }
}
