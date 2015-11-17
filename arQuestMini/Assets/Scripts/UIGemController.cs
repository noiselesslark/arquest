using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

public class UIGemController : MonoBehaviour {

    List<RawImage> gemImgs;
    public Texture IntelligemTexture;
    public Texture IntelligemOutline;
    public Texture ClevergemTexture;
    public Texture ClevergemOutline;

    // Use this for initialization
    void Start () {
        UpdateGems();
    }

    public void UpdateGems()
    {
        gemImgs = new List<RawImage>();
        foreach (Transform child in transform)
        {
            RawImage childgo = child.transform.gameObject.GetComponent<RawImage>(); ;
            if (childgo.name.Contains("gemImg"))
            {
                childgo.GetComponent<RawImage>();

                if (childgo.name.Contains("9"))
                {
                    childgo.texture = IntelligemOutline;
                }
                else
                {
                    childgo.texture = ClevergemTexture;
                }

                gemImgs.Add(childgo);
            }
        }

        gemImgs = gemImgs.OrderBy(gameObject => gameObject.name).ToList();

        if (GlobalVariables.questionComplete)
        {
            gemImgs[9].texture = IntelligemTexture;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
