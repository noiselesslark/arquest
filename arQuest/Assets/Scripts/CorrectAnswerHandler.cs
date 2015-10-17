using UnityEngine;

public class CorrectAnswerHandler : MonoBehaviour {

	public CorrectAnswerPopUpHandler popUp;
    private Color defaultColor;
    private Color correctColour;
    private Material mat;

    void Start()
    {
        correctColour = new Color(0.0F, 0.0F, 0.5F);
        mat = gameObject.GetComponent<Renderer>().material;
        defaultColor = mat.color;
    }

    void OnTouchDown()
    {
        mat.color = correctColour;
    }

    void OnTouchUp()
    {
        mat.color = defaultColor;
		popUp.transform.gameObject.SetActive(true);
    }

    void OnTouchStay()
    {
        mat.color = correctColour;
    }

    void OnTouchExit()
    {
        mat.color = defaultColor;
    }
}
