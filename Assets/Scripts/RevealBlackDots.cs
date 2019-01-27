using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealBlackDots : MonoBehaviour
{
    public Camera cam;
    public Button button;
    public Text instructions;

    private void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        button.onClick.AddListener(OnClick);

        instructions = GameObject.FindGameObjectWithTag("Instructions").GetComponent<Text>();
    }

    public void OnClick()
    {
        // Change camera background color to white
        cam.backgroundColor = Color.white;

        // Change instructions to explanations about data bias
        instructions.color = Color.black;
        instructions.text = "You seem to have missed some dots! Forced perspective " +
        	"like this can be used in data representation and cause bias in the " +
        	"overall results.";
    }
}
