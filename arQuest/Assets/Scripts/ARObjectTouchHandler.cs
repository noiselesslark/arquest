using UnityEngine;
using System.Collections;

public class ARObjectTouchHandler : MonoBehaviour {
    public string sceneName;

    void Start()
    {
    }

    void OnTouchDown()
    {
    }

    void OnTouchUp(string name)
    {
        Application.LoadLevel(sceneName);
    }

    void OnTouchStay()
    {
    }

    void OnTouchExit()
    {

    }
}
