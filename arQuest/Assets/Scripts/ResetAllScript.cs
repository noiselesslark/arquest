using UnityEngine;
using System.Collections;

public class ResetAllScript : MonoBehaviour {
    public GemController pedestal;
    public UIGemController UICounter;

    void OnTouchUp(string name)
    {
        GlobalVariables.completedQs = new System.Collections.Generic.Dictionary<string, bool>();
        GlobalVariables.feedbackComplete = false;
        pedestal.UpdateGems();
        UICounter.UpdateGems();

    }
}
