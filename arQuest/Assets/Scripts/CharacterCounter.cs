using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterCounter : MonoBehaviour {

    public void RefreshCounter(string text)
    {
        int count = text.Length;

        gameObject.GetComponent<Text>().text = count + "/140";
    }
}
