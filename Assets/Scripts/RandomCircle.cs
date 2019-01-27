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
        for (int k = 0; k < numToSpawn; k++)
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

            GameObject gameObj = new GameObject(string.Concat("random_dot_", k.ToString())); // names the new object
            gameObj.transform.position = new Vector2(x, y); // Gives it its location
            SpriteRenderer spriteRend = gameObj.AddComponent<SpriteRenderer>(); // Adds the sprite renderer to the gameobject
            gameObj.AddComponent<Location>(); // Adds the Location script to it
            spriteRend.sprite = spt; // Sets the sprite to be the circle
            gameObj.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(r, 1, 1); // Sets the random color
            gameObj.transform.parent = circleParent.transform; // makes the new object a child of the CircleParent
            //Debug.Log(string.Concat("Red: ", r, ", Green: ", g, "Blue: ", b, " at x: ", x, " y: ", y, "\n"));
        }

        // This section will deal with how to make sure no dots overlap
        GameObject[] LoCir = new GameObject[this.transform.childCount]; //Makes a Gameobject array

        //Fills said array of children
        for (int k = 0; k < this.transform.childCount; k ++)
        {
            LoCir[k] = this.transform.GetChild(k).gameObject;
        }

        // Checks is the spot is safe
        /*
        bool safe = false;
        Loc thisLoc = buildLoc(x, y, gameObj); // makes the location to check.
        while (!safe) //while not...
        {
            bool collided = false; // has it collieded?
            foreach (GameObject other in LoCir) // Runs once per child
            {
                if (other.GetComponent<Location>().collision(thisLoc)) // If it does collide
                {
                    collided = true;
                    break; //ends the foreach loop
                }
            }
            if (collided == true) // If we need to run through it again, i.e. if a collision was found
            {
                //New X and Y
                x = Random.Range(xMin, xMax);
                y = Random.Range(yMin, yMax);
                gameObj.transform.position = new Vector2(x, y);
            }
            else
            {
                safe = true;
            }
        }
        */
    }

    private Loc buildLoc(float curX, float curY, GameObject go)
    {
        float scaleX, scaleY, minX, minY, maxX, maxY;
        scaleX = go.transform.localScale.x;
        scaleY = go.transform.localScale.y;
        minX = curX - (scaleX / 2);
        maxX = curX + (scaleX / 2);
        minY = curY - (scaleY / 2);
        maxY = curY + (scaleY / 2);
        return new Loc(minX, maxX, minY, maxY);
    }
}
