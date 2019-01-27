using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleClick : MonoBehaviour
{
    private SpriteRenderer sr;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
            sr.color = Color.HSVToRGB(0, 1, 1);
    }
}
