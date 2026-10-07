using System.Collections.Generic;
using UnityEngine.Events;

public class EventCenter : Singleton<EventCenter>
{
    public Dictionary<string, UnityAction<object>> eventCenter = new Dictionary<string, UnityAction<object>>();

    public void AddEventListener(string eventName, UnityAction<object> action)
    {
        if(!eventCenter.ContainsKey(eventName))
        {
            eventCenter.Add(eventName, action);
        }
        else
        {
            eventCenter[eventName] += action;
        }
    }

    public void RemoveEventListener(string eventName, UnityAction<object> action)
    {
        if (eventCenter.ContainsKey(eventName))
            eventCenter[eventName] -=  action;
    }

    public void TriggerListener(string eventName,object info)
    {
        if(eventCenter.ContainsKey(eventName))
            eventCenter[eventName]?.Invoke(info);
    }
}
