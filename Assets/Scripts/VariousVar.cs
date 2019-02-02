using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The whole point of this class is to just hold the clicked variable
/// </summary>
public class VariousVar : MonoBehaviour
{

    public bool clicked;

    // This is the start function which is called when the
    // interactive starts. It sets the boolean value of clicked
    // to false.
    void Start()
    {
        clicked = false;
    }
}
