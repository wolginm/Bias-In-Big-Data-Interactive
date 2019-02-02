using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RevealBlackDots : MonoBehaviour
{
    public Camera cam;
    public Button button;
    public Text instructions;
    private bool alreadyClicked;

    // This is the start function which is called when the
    // interactive starts. It sets the boolean value of
    // alreadyClicked to false, sets cam to be the main camera
    // and adds an on click listener for the button.
    private void Start()
    {
        alreadyClicked = false;
        cam = GameObject.FindGameObjectWithTag("Main Camera").GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        button.onClick.AddListener(OnClick);

        instructions = GameObject.FindGameObjectWithTag("Instructions").GetComponent<Text>();
    }

    // This function checks if the button has been clicked and, if not,
    // sets the camera background color to white. It also changes the text
    // color to black and changes the text on the screen.
    // If the button has already been clicked, clicking it again will load
    // the next scene.
    public void OnClick()
    {
        if (!alreadyClicked)
        {
            // Change camera background color to white
            cam.backgroundColor = Color.gray;

            // Change instructions to explanations about data bias
            instructions.color = Color.black;
            instructions.text = "You seem to have missed some dots! Forced perspective " +
                "like this can be used in data representation and cause bias in the " +
                "overall results.";
            alreadyClicked = true;
        }
        else
        {
            SceneManager.LoadScene("Slider Example");
        }

    }
}
