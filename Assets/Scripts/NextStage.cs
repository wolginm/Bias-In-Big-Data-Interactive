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

    // This function takes the scene name in the form of a
    // string and loads the scene that matches that string.
    public void changeMenuScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
