using System;

public interface IEventModel
{
    void SubscribeToEvent(GameEvents e, Action<object, object> callback);
    void UnsubscribeFromEvent(GameEvents e, Action<object, object> observer);
    void InvokeEvent(GameEvents e, object sender, object eventArgs);
    void Reset();
}