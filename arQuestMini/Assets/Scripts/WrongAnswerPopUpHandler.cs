using UnityEngine;
using System.Collections;

public class WrongAnswerPopUpHandler : MonoBehaviour {
	
	public float visibilityTimeSeconds;
	private float resetTime;

	// Use this for initialization
	void Start () {
		resetTime = visibilityTimeSeconds;
	}
	
	// Update is called once per frame
	void Update () {
		visibilityTimeSeconds -= Time.deltaTime;

		if (visibilityTimeSeconds < 0){
			transform.gameObject.SetActive(false);
			visibilityTimeSeconds = resetTime;
		}
	}

	void OnTouchUp()
    {
		transform.gameObject.SetActive(false);	
		visibilityTimeSeconds = resetTime;	
	}

}
