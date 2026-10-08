using UnityEngine;
using UnityEngine.Events;

public class MonoController : MonoBehaviour
{
    public event UnityAction updateAction;
    void Start()
    {
    }
    void Update()
    {
        updateAction?.Invoke();
    }

    public void AddUpdateListener(UnityAction action)
    {
        updateAction += action;
    }
    
    public void RemoveUpdateListener(UnityAction action)
    {
        updateAction -= action;
    }
}
