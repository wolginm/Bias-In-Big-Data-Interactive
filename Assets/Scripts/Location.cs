using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    public float minX, maxX, minY, maxY;
    public Loc thisLoc;

    // This function is called before the first frame update.
    void Start()
    {
        buildLoc();
    }

    // This function [INSERT WHAT FUNCTION DOES HERE].
    public void buildLoc()
    {
        float curX, curY, scaleX, scaleY;
        curX = transform.position.x;
        curY = transform.position.y;
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        minX = curX - (scaleX / 2);
        maxX = curX + (scaleX / 2);
        minY = curY - (scaleY / 2);
        maxY = curY + (scaleY / 2);
        thisLoc = new Loc(minX, maxX, minY, maxY);
        //Debug.Log(string.Concat(transform.localPosition.x, " ", transform.localPosition.y));
        //Debug.Log(string.Concat("Loc Created: ", this.gameObject.name));
    }

    // This function takes [INSERT WHAT OTHER IS AND WHAT TYPE IT IS HERE]
    // and [INSERT WHAT FUNCTION DOES HERE].
    public bool collision(Loc other)
    {
        return thisLoc.collision(other);
    }
}

public class Loc
{
    public float minX, minY, maxX, maxY;

    // This function takes [INSERT WHAT VARIABLES ARE AND WHAT TYPE THEY ARE
    // HERE] and [INSERT WHAT FUNCTION DOES HERE].
    public Loc(float a, float b, float c, float d)
    {
        minX = a; minY = c; maxX = b; maxY = d;
    }
  
    // This function takes [INSERT WHAT VARIABLES ARE AND WHAT TYPE THEY ARE
    // HERE] and [INSERT WHAT FUNCTION DOES HERE].
    public Loc(float curX, float curY)
    {
        minX = curX - 2;
        maxX = curX + 2;
        minY = curY - 2;
        maxY = curY + 2;
    }

    /// <summary>
    /// If ture, a collions was found
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool collision(Loc other)
    {
        if (other.minX >= this.minX && other.minX <= this.maxX)
        {
            if (other.maxY >= this.minY && other.maxY <= this.maxY) return true;
            else if (other.minY <= this.maxY && other.minY >= this.minY) return true;
            else return false;
        }
        if (other.maxX >= this.minX && other.maxX <= this.maxX)
        {
            if (other.maxY >= this.minY && other.maxY <= this.maxY) return true;
            else if (other.minY <= this.maxY && other.minY >= this.minY) return true;
            else return false;
        }
        else return false;
    }

    // This function takes [INSERT WHAT VARIABLES ARE AND WHAT TYPE THEY ARE
    // HERE] and [INSERT WHAT FUNCTION DOES HERE].
    public bool click(float x, float y)
    {
        if ((minX <= x && maxX >= x) && (minY <= y && maxY >= y)) return true;
        else return false;
    }

    // This function is our ToString function.
    public string ToString => string.Concat("minX:", minX, " maxX: ", maxX, " minY: ", minY, " maxY: ", maxY);
}
