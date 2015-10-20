using UnityEngine;
using System.Collections;

public class ARObjectTouchHandler : MonoBehaviour {

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
                Application.LoadLevel("defaultQuestionScene");
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
