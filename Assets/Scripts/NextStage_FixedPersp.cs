using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage_FixedPersp : MonoBehaviour
{
    //void OnMouseUp()
    //{
    //    SceneManager.LoadScene("Slider Example", LoadSceneMode.Single);
    //}

    public void changemenuscene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
