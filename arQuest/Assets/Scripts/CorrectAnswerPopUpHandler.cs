using UnityEngine;

public class CorrectAnswerPopUpHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void OnTouchUp()
    {
        GlobalVariables.completedQs[Application.loadedLevelName] = true;

        gameObject.transform.GetChild(1).gameObject.SetActive(false); // Hide gem

        Application.LoadLevel("workingScene");
    }
}
