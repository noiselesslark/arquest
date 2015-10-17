using UnityEngine;
using System.Collections;

public class CorrectAnswerPopUpHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void OnTouchUp()
    {
        GlobalVariables.completedQs[GlobalVariables.ocuClass] = true;
        Application.LoadLevel("workingScene");
    }
}
