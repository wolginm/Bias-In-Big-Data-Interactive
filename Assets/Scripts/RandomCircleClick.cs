using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomCircleClick : MonoBehaviour
{
    private SpriteRenderer sr;
    public GameObject[] LoC;
    private Camera cam;
    public Text textCount;
    private int counter;
    // this. is the circle parent

    private void Start()
    {
        Debug.Log("Hit Click Start");
        cam = Camera.main;
        counter = 0;
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
            Vector3 point = new Vector3();
            Vector2 mousePos = new Vector2();

            mousePos.x = Input.mousePosition.x;
            mousePos.y = cam.pixelHeight - Input.mousePosition.y;

            point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, (mousePos.y + Camera.main.orthographicSize + (float).5), cam.nearClipPlane));

            Debug.Log(point.ToString("F3"));
            Debug.Log(LoC.Length);
            foreach(GameObject go in LoC)
            {
                Loc goLoc = go.GetComponent<Location>().thisLoc;
                if (goLoc.click(point.x, -1 * point.y))
                {
                    Debug.Log(goLoc.ToString);
                    Debug.Log(new Loc(Input.mousePosition.x, Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.y).ToString);
                    sr = go.GetComponent<SpriteRenderer>();
                    Debug.Log(Input.mousePosition);
                    sr.color = Color.HSVToRGB(0, 0, 100);
                    if (go.GetComponent<VariousVar>().clicked == false)
                    {
                        counter++;
                        textCount.text = counter.ToString();
                        go.GetComponent<VariousVar>().clicked = true;
                    }
                }
            }
            
        }
            

    }
}
