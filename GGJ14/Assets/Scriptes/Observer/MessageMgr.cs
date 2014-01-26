using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//message qu'on peut envoyer
public enum eMessageID
{
    eScoreJ1,
    eScoreJ2,
    ePlusBotJ1,
    ePlusBotJ2,
    eMoinsBotJ1,
    eMoinsBotJ2
}

public interface IMessageListener
{
    void OnMessage(eMessageID _messageID, GameObject _sender);
}

public class MessageMgr
{
    static MessageMgr m_Instance = null;

    public static MessageMgr Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new MessageMgr();
            }
            return m_Instance;
        }
    }

    protected List<IMessageListener> m_listeners = new List<IMessageListener>(10);

    public void AddListener(IMessageListener _listener)
    {
        m_listeners.Add(_listener);
    }

    public void RemoveListener(IMessageListener _listener)
    {
        m_listeners.Remove(_listener);
    }

    public void NotifyObservers(eMessageID _messageID, GameObject _sender)
    {
        foreach (IMessageListener observers in m_listeners)
        {
            observers.OnMessage(_messageID, _sender);
        }
    }
}