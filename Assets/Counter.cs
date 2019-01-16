using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public float Score = 0;
    public float previousScore = 0;
    public Text sscore;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Score = previousScore + 1;
            previousScore = Score;
            Debug.Log(Score);
            sscore.text = Score.ToString();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Score = previousScore - 1;
            previousScore = Score;
            Debug.Log(Score);
            sscore.text = Score.ToString();
        }
    }
}
