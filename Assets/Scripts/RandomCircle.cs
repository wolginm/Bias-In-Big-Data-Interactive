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
        r = r / 255;
        g = g / 255;
        b = b / 255;
        x = Random.Range(xMin, xMax);
        y = Random.Range(yMin, yMax);

        GameObject gameObj = new GameObject(string.Concat("random_dot_", 1.ToString()));
        gameObj.transform.position = new Vector2(x, y);
        SpriteRenderer spriteRend = gameObj.AddComponent<SpriteRenderer>();
        gameObj.AddComponent<Location>();
        spriteRend.sprite = spt;
        gameObj.GetComponent<SpriteRenderer>().color = new Color(r, g, b);
        gameObj.transform.parent = circleParent.transform;


        GameObject[] LoCir = new GameObject[this.transform.childCount];
        for (int k = 0; k < this.transform.childCount; k ++)
        {
            LoCir[k] = this.transform.GetChild(k).gameObject;
        }


        bool safe = false;
        while (!safe)
        {
            bool collided = false;
            foreach (GameObject other in LoCir)
            {
                if (gameObj.GetComponent<Location>().collision(other.GetComponent<Location>().thisLoc))
                {
                    collided = true;
                    break;
                }
            }
            if (collided == true)
            {
                x = Random.Range(xMin, xMax);
                y = Random.Range(yMin, yMax);
                gameObj.transform.position = new Vector2(x, y);
            }
        }

        Debug.Log(string.Concat("Red: ", r, ", Green: ", g, "Blue: ", b, " at x: ", x, " y: ", y, "\n"));
    }
}
