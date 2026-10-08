using System.Collections;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class MonoManager : Singleton<MonoManager>
{
    private MonoController controller;

    public MonoManager()
    {
        //保证了MonoController的唯一性
        GameObject go = new GameObject("MonoController");
        controller = go.AddComponent<MonoController>();
    }
    
    public void AddUpdateListener(UnityAction action)
    {
        controller.updateAction += action;
    }
    
    public void RemoveUpdateListener(UnityAction action)
    {
        controller.updateAction -= action;
    }

    public Coroutine StartCoroutine(IEnumerator routine)
    {
        return controller.StartCoroutine(routine);
    }

    public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
    {
        return controller.StartCoroutine(methodName, value);
    }

    public Coroutine StartCoroutine(string methodName)
    {
        return controller.StartCoroutine(methodName);
    }
}
