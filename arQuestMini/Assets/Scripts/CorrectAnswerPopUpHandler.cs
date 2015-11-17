using UnityEngine;

public class CorrectAnswerPopUpHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

	void OnTouchUp()
    {
        GlobalVariables.questionComplete = true;

        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false); // Hide gem
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
        
        Application.LoadLevel(GlobalVariables.HOME_SCN);
    }
}
