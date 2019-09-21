using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum GameEvents
{
    OnDebugMsg,
    OnShowMessage,
    JetCollides,
    SpawnJets,
    initExplosion
}

public class EventController : MonoBehaviour
{

    // +++ private fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private EventModel _eventModel;
    private static EventController _instance;




    // +++ editor fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public bool logGameEvents;




    // +++ unity callbacks ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Awake()
    {
        _eventModel = new EventModel();

        _instance = this;
    }




    // +++ public class methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public static void SubscribeToEvent(GameEvents eventToSubscribeTo, Action<object, object> callback)
    {
        _instance._eventModel.SubscribeToEvent(eventToSubscribeTo, callback);
    }

    public static void UnsubscribeFromEvent(GameEvents eventToUnsubscribeFrom, Action<object, object> callback)
    {
        _instance._eventModel.UnsubscribeFromEvent(eventToUnsubscribeFrom, callback);
    }

    public static void InvokeEvent(GameEvents e, object sender, object eventArgs)
    {
        _instance._eventModel.InvokeEvent(e, sender, eventArgs);

        if (!_instance.logGameEvents) return;

        Debug.LogFormat("{0} called from {1}", e.ToString(), sender.GetType().ToString());
    }

    public static void Reset()
    {
        _instance._eventModel.Reset();
    }
}