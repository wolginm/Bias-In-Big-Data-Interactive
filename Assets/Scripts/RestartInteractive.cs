using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartInteractive : MonoBehaviour
{
    public void restartinteractive(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
