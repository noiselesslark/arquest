using UnityEngine;
using System.Collections.Generic;

public class GlobalVariables : MonoBehaviour {
    public static Dictionary<string, bool> completedQs = new Dictionary<string, bool>();
    public static bool feedbackComplete = false;

    public const string CONSUMER_KEY = "o8ToOUWj18PG1WIUAX9e5n329";
    public const string CONSUMER_SECRET = "wvkMQwbGyrnpChKsYPctrTFlJgQHbbIF7HiPH94TMKdnYaTiIo";

    public const string Twitter_User_id = "4038493461";
    public const string Twitter_Screen_Name= "arQuest";

    public const  string Twitter_User_Token = "4038493461-J7tMYD7S01Zn1VfBDXtlA9auC5YkIvW75etAh1M";
    public const string Twitter_User_Token_Secret = "q2RPxklmYau7UJxVIhGI8oBXO95GnTbInfX3O67oDTmEz";

    public const string HOME_SCN = "workingScene";
    public const string FEEDBACK_SCN = "feedbackScene";
    public const string OCUCLASS_SCN = "ocuClassScene";
    public const string LMN_SCN = "LMNScene";
    public const string LOSTIN_SCN = "lostinScene";
    public const string XCURSION_SCN = "xcursionScene";
    public const string ARCIRCUITS_SCN = "arCircuitsScene";
    public const string COMPANION_SCN = "companionScene";
    public const string DP_SCN = "DPScene";
    public const string HAMLIN_SCN = "hamlinScene";
    public const string HOLOBEATS_SCN = "holobeatsScene";

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);

        //completedQs.Add(FEEDBACK_SCN, false);
        completedQs.Add(OCUCLASS_SCN, false);
        completedQs.Add(LMN_SCN, false);
        completedQs.Add(LOSTIN_SCN, false);
        completedQs.Add(XCURSION_SCN, false);
        completedQs.Add(ARCIRCUITS_SCN, false);
        completedQs.Add(COMPANION_SCN, false);
        completedQs.Add(DP_SCN, false);
        completedQs.Add(HAMLIN_SCN, false);
        completedQs.Add(HOLOBEATS_SCN, false);
    }

    public static int getNumberCompleted()
    {
        int count = 0;

        foreach(KeyValuePair<string, bool> kvp in completedQs)
        {
            if(kvp.Value == true)
            {
                count++;
            }
        }

        return count;
    }
}
