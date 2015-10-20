using UnityEngine;
using System.Collections;

public class GemVisibilityHandler : MonoBehaviour {
    public string SceneName;
	
    // Use this for initialization
	void Start () {
        if (GlobalVariables.completedQs[SceneName]){
            transform.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
