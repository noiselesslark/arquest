using UnityEngine;
using System.Collections;

public class ARObjectTouchHandler : MonoBehaviour {
    public Color defaultColor;
    public Color selectedColor;

    void Start()
    {
    }

    void OnTouchDown()
    {
    }

    void OnTouchUp(string name)
    {
        switch (name)
        {
            case "OcuClassModel":
                Application.LoadLevel("ocuClassScene");
                break;
            default:
                break;
        }
    }

    void OnTouchStay()
    {
    }

    void OnTouchExit()
    {

    }
}
