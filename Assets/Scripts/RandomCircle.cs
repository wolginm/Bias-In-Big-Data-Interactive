using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCircle : MonoBehaviour
{
    public GameObject[] theGoodies;
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
    void Update()
    {
        if (numToSpawn <= 0) return;
        int randy = Random.Range(0, theGoodies.Length);
        Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Transform trans = theGoodies[randy].transform;
        trans.transform.position = pos;

        // Choose a new goods to spawn from the array (note I specifically call it a 'prefab' to avoid confusing myself!)
        GameObject goodsPrefab = theGoodies[randy];

        // Creates the random object at the random 2D position.
        Instantiate(goodsPrefab, trans);
        numToSpawn--;

    }
}
