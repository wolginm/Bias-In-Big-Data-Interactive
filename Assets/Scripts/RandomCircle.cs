using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircle : MonoBehaviour
{
    public GameObject refC;
    private SpriteRenderer spriteRend;
    public int numToSpawn;

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;

    // Update is called once per frame


    private void Start()
    {
        int r, g, b;
        float x, y;
        Vector2 currentPosition = refC.transform.position;
        GameObject temp = Instantiate(refC);
        spriteRend = Instantiate((SpriteRenderer) refC.GetComponent(typeof(SpriteRenderer)));


        /*for (int i = 0; i < 10; i++)
        {
            temp.name = string.Concat("random_dot_", i); 
            r = Random.Range(0, 255);
            g = Random.Range(0, 255);
            b = Random.Range(0, 255);
            x = Random.Range(xMin, xMax);
            y = Random.Range(yMin, yMax);
            currentPosition = new Vector2(x, y);
            (temp.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer).color = new Color(r, g, b);
            Color c = (temp.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer).color;

            Debug.Log(string.Concat("Red: ", r, ", Green: ", g, "Blue: ", " at x: ", x, " y: ", y, 
                " Color: ", c, "\n"));
            GameObject tmpObj = GameObject.Instantiate(temp, currentPosition, Quaternion.identity) as GameObject;
            Debug.Log((tmpObj.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer).color);
        }*/
    }
}
