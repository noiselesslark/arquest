using UnityEngine;
using System.Collections.Generic;

public class GemController : MonoBehaviour {

    List<GameObject> gems;

	// Use this for initialization
	void Start () {
        gems = new List<GameObject>();
        int completedCount = GlobalVariables.getNumberCompleted();
        foreach (Transform child in transform)
        {
            
            GameObject childgo = child.transform.gameObject;
            if (childgo.name.Contains("gem"))
            {

                childgo.SetActive(false);

                gems.Add(childgo);
            }
        }

        gems.Sort();
        Debug.Log("MESSAGE!!!! ALL THE GEMS ARE " + gems.Count);

        for (int i = 0; i < completedCount; i++)
        {
            Debug.Log("MESSAGE!!!! Set visible gem " + i);
            gems[i].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
