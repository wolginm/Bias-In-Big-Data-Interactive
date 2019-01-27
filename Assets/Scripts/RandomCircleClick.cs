using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircleClick : MonoBehaviour
{
    private SpriteRenderer sr;
    private GameObject[] LoC;

    // this. is the circle parent

    private void Start()
    {
        Debug.Log("Hit Click Start");
    }

    void OnTransformChildrenChanged()
    {
        int children = this.transform.childCount;
        if (children == (this.GetComponent<RandomCircle>().numToSpawn + 3))
        {
            LoC = new GameObject[children];
            for (int k = 0; k < children; k++)
            {
                LoC[k] = this.transform.GetChild(k).gameObject;
                Debug.Log(LoC[k]);
            }
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Pressed primary button.");
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.mousePosition);
            foreach(GameObject go in LoC)
            {
                Loc goLoc = go.GetComponent<Location>().thisLoc;
                if (goLoc.click(Input.mousePosition.x, Input.mousePosition.y))
                {
                    Debug.Log(goLoc.ToString);
                    Debug.Log(new Loc(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.y).ToString);
                    sr = go.GetComponent<SpriteRenderer>();
                    Debug.Log(Input.mousePosition);
                    sr.color = Color.HSVToRGB(0, 1, 1);
                }
            }
            
        }
            

    }
}
