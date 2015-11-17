using UnityEngine;
using System.Collections.Generic;

public class GlobalVariables : MonoBehaviour {
    public static bool questionComplete = false;

    public const string HOME_SCN = "workingScene";

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
    }

}
