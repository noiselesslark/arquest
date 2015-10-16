using UnityEngine;
using System.Collections;

public class IncorrectAnswerHandler : MonoBehaviour {

    private Color defaultColor;
    public Color incorrectColour;
    private Material mat;

    void Start()
    {
        incorrectColour = new Color(0.5F, 0.0F, 0.0F);
        mat = gameObject.GetComponent<Renderer>().material;
        defaultColor = mat.color;
    }

    void OnTouchDown()
    {
        mat.color = incorrectColour;
    }

    void OnTouchUp()
    {
        mat.color = defaultColor;
    }

    void OnTouchStay()
    {
        mat.color = incorrectColour;
    }

    void OnTouchExit()
    {
        mat.color = defaultColor;
    }
}
