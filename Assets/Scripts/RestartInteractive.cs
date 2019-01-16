using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartInteractive : MonoBehaviour
{
    public void restartinteractive(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}
