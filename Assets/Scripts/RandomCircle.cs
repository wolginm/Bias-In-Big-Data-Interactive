using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircle : MonoBehaviour
{
    public GameObject circleParent;
    public Sprite spt;
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
        float r, g, b;
        float x, y;

        r = (float)(Random.Range(0, 255));
        g = (float)(Random.Range(0, 255));
        b = (float)(Random.Range(0, 255));
        x = Random.Range(xMin, xMax);
        y = Random.Range(yMin, yMax);

        GameObject gameObj = new GameObject(string.Concat("random_dot_", 1.ToString()));
        gameObj.transform.position = new Vector2(x, y);
        SpriteRenderer spriteRend = gameObj.AddComponent<SpriteRenderer>();
        spriteRend.sprite = spt;
        gameObj.GetComponent<SpriteRenderer>().color = new Color(r, g, b);
        gameObj.transform.parent = circleParent.transform;
        Debug.Log(string.Concat("Red: ", r, ", Green: ", g, "Blue: ", b, " at x: ", x, " y: ", y, "\n"));


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
