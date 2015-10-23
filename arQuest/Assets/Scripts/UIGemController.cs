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
        int completedCount = GlobalVariables.getNumberCompleted();



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
                    childgo.texture = ClevergemOutline;
                }

                gemImgs.Add(childgo);
            }
        }

        gemImgs = gemImgs.OrderBy(gameObject => gameObject.name).ToList();

        for (int i = 0; i < completedCount; i++)
        {

            if (gemImgs[i].name.Contains("9"))
            {
                gemImgs[i].texture = IntelligemTexture;
            }
            else
            {
                gemImgs[i].texture = ClevergemTexture;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
