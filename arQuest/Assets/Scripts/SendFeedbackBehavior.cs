using UnityEngine;
using Twitter;
using UnityEngine.UI;


public class SendFeedbackBehavior : MonoBehaviour {
    public GameObject thankyouPanel;
    public GameObject sendingPanel;


    public void PostFeedback()
    {
        // Get text of field. 
        string tweet = gameObject.GetComponent<Text>().text;

        AccessTokenResponse ATR = new AccessTokenResponse();
        ATR.ScreenName = GlobalVariables.Twitter_Screen_Name;
        ATR.Token = GlobalVariables.Twitter_User_Token;
        ATR.UserId = GlobalVariables.Twitter_User_id;
        ATR.TokenSecret = GlobalVariables.Twitter_User_Token_Secret;

        sendingPanel.transform.gameObject.SetActive(true);

        StartCoroutine(API.PostTweet(tweet, GlobalVariables.CONSUMER_KEY, GlobalVariables.CONSUMER_SECRET, ATR,
               new PostTweetCallback(OnPostTweet)));
    }


    void OnPostTweet(bool success)
    {
        Debug.Log("SUCCEEDED? " + success);

        sendingPanel.transform.gameObject.SetActive(false);
        thankyouPanel.transform.gameObject.SetActive(true);

        GlobalVariables.feedbackComplete = true;

        Application.LoadLevel("workingScene");
    }
}
