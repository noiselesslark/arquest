using UnityEngine;
using System.Collections;

public class ResetAllScript : MonoBehaviour {
    public GemController pedestal;
    public UIGemController UICounter;

    void OnTouchUp(string name)
    {
        GlobalVariables.questionComplete = false;
        pedestal.UpdateGems();
        UICounter.UpdateGems();

    }
}
