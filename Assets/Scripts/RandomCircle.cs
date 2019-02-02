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

    // This is the start function which is called when the
    // interactive starts. It [INSERT WHAT IT DOES HERE].
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

            GameObject gameObj = new GameObject(string.Concat("random_dot_", k.ToString())); // names the new object

            GameObject[] LoCir = new GameObject[this.transform.childCount]; //Makes a Gameobject 
            for (int j = 0; j < this.transform.childCount; j++)
            {
                LoCir[j] = this.transform.GetChild(j).gameObject;
            }

            Debug.Log(LoCir.Length);

            bool safe = false;
            while (safe == false)
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
            gameObj.transform.position = new Vector2(x, y); // Gives it its location
            SpriteRenderer spriteRend = gameObj.AddComponent<SpriteRenderer>(); // Adds the sprite renderer to the gameobject
            gameObj.AddComponent<Location>(); // Adds the Location script to it
            gameObj.AddComponent<VariousVar>(); // Adds the VariousVar script to it
            spriteRend.sprite = spt; // Sets the sprite to be the circle
            gameObj.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(r, 1, 1); // Sets the random color
            gameObj.transform.parent = circleParent.transform; // makes the new object a child of the CircleParent
        }
    }
}
