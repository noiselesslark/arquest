using UnityEngine;

public class ARObjectTouchHandler : MonoBehaviour {
    public string sceneName;


    void OnTouchUp(string name)
    {
        Application.LoadLevel(sceneName);
    }
}
