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

    // This function makes a new Loc indirectly, ment to be called when an item is created.
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
    }

    /// <summary>
    /// Takes a Loc and tries to compare it if collides
    /// </summary>
    /// <param name="other">Location</param>
    /// <returns>True if it is a collision, Flase otherwise</returns>
    public bool collision(Loc other)
    {
        return thisLoc.collision(other);
    }
}

/// <summary>
/// The Loc class holds the boundry for an item
/// </summary>
public class Loc
{
    public float minX, minY, maxX, maxY;
/// <summary>
///  Makes a new loc
/// </summary>
/// <param name="a">minX</param>
/// <param name="b">maxX</param>
/// <param name="c">minY</param>
/// <param name="d">maxY</param>
    public Loc(float a, float b, float c, float d)
    {
        minX = a; minY = c; maxX = b; maxY = d;
    }
  
    /// <summary>
    /// Makes a new loc
    /// </summary>
    /// <param name="curX">curX</param>
    /// <param name="curY">curY</param>
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
    /// <param name="other">A Loc</param>
    /// <returns>Ture if collision detected</returns>
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

    /// <summary>
    /// Not used code...
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool click(float x, float y)
    {
        if ((minX <= x && maxX >= x) && (minY <= y && maxY >= y)) return true;
        else return false;
    }

    // This function is our ToString function.
    public string ToString => string.Concat("minX:", minX, " maxX: ", maxX, " minY: ", minY, " maxY: ", maxY);
}
