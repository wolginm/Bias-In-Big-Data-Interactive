using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFloat : MonoBehaviour
{
    public Slider slider;
    //public Text text;
    public Image img;

    // Start is called before the first frame update

    // Update is called once per frame and updates the color
    // based on the slider's position.
    void Update()
    {
        //text.text = slider.value.ToString();
        img.color = EightBitColor((int)slider.value);
        
    }

    // This function sets the color value.
    private Color EightBitColor(int bit)
    {
        float t = (float)bit / 255;
        return Color.HSVToRGB(t, 1, 1);
    }
}
