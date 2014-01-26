using UnityEngine;
using System.Collections;

public class Observer : MonoBehaviour, IMessageListener {
    public static int scoreJ1;
    public static int scoreJ2;
    public static int nbBotJ1;
    public static int nbBotJ2;

	// Use this for initialization
	void Start () {
        MessageMgr.Instance.AddListener(this);
        scoreJ1 = 0;
        scoreJ2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMessage(eMessageID _messageID, GameObject _sender)
    {

        if (_messageID == eMessageID.eScoreJ1)
        {
            scoreJ1++;
        }
        else if (_messageID == eMessageID.eScoreJ2)
        {
            scoreJ2++;
        }
        
        if (_messageID == eMessageID.ePlusBotJ1)
        {
            nbBotJ1++;
        }
        else if (_messageID == eMessageID.ePlusBotJ2)
        {
            nbBotJ2++;
        }

        if (_messageID == eMessageID.eMoinsBotJ1)
        {
            nbBotJ1--;
        }
        else if (_messageID == eMessageID.eMoinsBotJ2)
        {
            nbBotJ2--;
        }
    }

    void OnDestroy()
    {
        MessageMgr.Instance.RemoveListener(this);
    }

}
