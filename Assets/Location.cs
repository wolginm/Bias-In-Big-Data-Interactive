using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    public Loc thisLoc;

    // Start is called before the first frame update
    void Start()
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
        //Debug.Log(string.Concat("X, ", minX, " ", maxX));
    }

    public bool collision(Loc other)
    {
        return thisLoc.collision(other);
    }
}
public class Loc
{
    public float minX, minY, maxX, maxY;
    public Loc(float a, float b, float c, float d)
    {
        minX = a; minY = c; maxX = b; maxY = d;
    }

    public bool collision(Loc other)
    {
        if (((other.minX > this.minX) && (other.minX < this.maxX)) ||
            ((other.maxX > this.minX) && (other.maxX < this.maxX)) ||
            ((other.minY > this.minY) && (other.minY < this.maxY)) ||
            ((other.maxY > this.minY) && (other.minY < this.maxY)))
        {
            return true;
        }
        else return false;
    }
}
