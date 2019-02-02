using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFloat : MonoBehaviour
{
    public Slider slider;
    public Image img;

    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        img.color = EightBitColor((int)slider.value);
        
    }

    private Color EightBitColor(int bit)
    {
        float t = (float)bit / 255;
        return Color.HSVToRGB(t, 1, 1);
    }
}
