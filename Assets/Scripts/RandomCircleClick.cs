using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleClick : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject CircleParent;
    private GameObject[] LoC;

    private void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        int children = CircleParent.transform.childCount;
        LoC = new GameObject[children];
        for (int k = 0; k < children; k++)
        {
            LoC[k] = CircleParent.transform.GetChild(k).gameObject;
            Debug.Log(LoC[k]);
        }

    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition);
            sr.color = Color.HSVToRGB(0, 1, 1);
        }
            

    }
}
