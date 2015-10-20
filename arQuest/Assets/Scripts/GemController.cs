using UnityEngine;
using System.Collections.Generic;
using System.Linq;

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

        gems = gems.OrderBy(gameObject => gameObject.name).ToList();

        for (int i = 0; i < completedCount; i++)
        {
            gems[i].SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
