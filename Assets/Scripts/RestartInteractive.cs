using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInteractive : MonoBehaviour
{
    // This function takes the scene name in the form of a
    // string and loads the scene that matches that string.
    public void restartInteractive(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
