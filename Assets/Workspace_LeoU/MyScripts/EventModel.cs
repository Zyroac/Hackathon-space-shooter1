using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventModel : IEventModel
{

    // +++ private fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private Dictionary<GameEvents, List<Action<object, object>>> _eventCallbacks;




    // +++ editor fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ public fields ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public EventModel()
    {
        _eventCallbacks = new Dictionary<GameEvents, List<Action<object, object>>>();
    }

    ~EventModel()
    {
        _eventCallbacks = null;
    }



    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ private class methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // +++ public class methods +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public void SubscribeToEvent(GameEvents e, Action<object, object> callback)
    {
        if (!_eventCallbacks.ContainsKey(e))
        {
            _eventCallbacks[e] = new List<Action<object, object>>();
        }

        _eventCallbacks[e].Add(callback);
    }


    public void UnsubscribeFromEvent(GameEvents e, Action<object, object> observer)
    {
        if (!_eventCallbacks.ContainsKey(e)) return;

        if (!_eventCallbacks[e].Contains(observer)) return;

        _eventCallbacks[e].Remove(observer);
    }

    public void InvokeEvent(GameEvents e, object sender, object eventArgs)
    {
        if (e != GameEvents.OnDebugMsg)
        {
            this.InvokeEvent(GameEvents.OnDebugMsg, this, e.ToString());
        }
        if (!_eventCallbacks.ContainsKey(e)) return;

        foreach (var observer in _eventCallbacks[e])
            observer(sender, eventArgs);
    }

    public void Reset()
    {
        _eventCallbacks = new Dictionary<GameEvents, List<Action<object, object>>>();
    }
}



