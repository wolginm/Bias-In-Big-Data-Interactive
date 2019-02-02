using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircle : MonoBehaviour
{
    public GameObject circleParent;     //Parent of the circle
    public Sprite spt;                  //The sprite to draw againts    
    public int numToSpawn;              //How many to spawn

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;

    // Update is called once per frame


    /// <summary>
    /// Auto places the dots, with a name, color, and location
    /// </summary>

    private void Start()
    {
        for (int k = 0; k < numToSpawn; k++)
        {
            float r, g, b;
            float x = 0;
            float y = 0;

            r = (float)(Random.Range(0, 255));
            g = (float)(Random.Range(0, 255));
            b = (float)(Random.Range(0, 255));
            r = r / 255;
            g = g / 255;
            b = b / 255;

            // names the new object
            GameObject gameObj = new GameObject(string.Concat("random_dot_", k.ToString()));

            // makes a GameObject
            GameObject[] LoCir = new GameObject[this.transform.childCount];
            for (int j = 0; j < this.transform.childCount; j++)
            {
                LoCir[j] = this.transform.GetChild(j).gameObject;
            }

            Debug.Log(LoCir.Length);

            bool safe = false;
            while (safe == false) //Checks if these conditions are good
            {
                x = Random.Range(xMin, xMax);
                y = Random.Range(yMin, yMax);
                Loc thisLoc = new Loc(x, y);
                for (int j = 0; j < LoCir.Length; j ++)
                {
                    float otherX = LoCir[j].transform.position.x;
                    float otherY = LoCir[j].transform.position.y;
                    Loc otherLoc = new Loc(otherX, otherY);
                    if (thisLoc.collision(otherLoc))
                    {
                        Debug.Log("Colided");
                    }
                    else
                    {
                        safe = true;
                        Debug.Log("Hit");
                    }
                }
                Debug.Log("Safe");
            }

            // gives it its location
            gameObj.transform.position = new Vector2(x, y);
            
            // adds the sprite renderer to the GameObject
            SpriteRenderer spriteRend = gameObj.AddComponent<SpriteRenderer>();
            
            // adds the location script to it
            gameObj.AddComponent<Location>();

            // adds the VariousVar script to it
            gameObj.AddComponent<VariousVar>();

            // sets the sprite to be the circle
            spriteRend.sprite = spt;

            // sets the random color
            gameObj.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(r, 1, 1);

            // makes the new object a child of the CircleParent
            gameObj.transform.parent = circleParent.transform;
        }
    }
}
