using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalVariables : MonoBehaviour {
    public static Dictionary<string, bool> completedQs = new Dictionary<string, bool>();

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(transform.gameObject);
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
