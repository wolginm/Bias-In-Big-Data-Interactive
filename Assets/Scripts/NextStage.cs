using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    //void OnMouseUp()
    //{
    //    SceneManager.LoadScene("Slider Example", LoadSceneMode.Single);
    //}

    public void changemenuscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
