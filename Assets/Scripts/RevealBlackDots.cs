using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealBlackDots : MonoBehaviour
{
    public Camera cam;
    public Button button;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        button.onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        cam.backgroundColor = Color.white;
    }
}
