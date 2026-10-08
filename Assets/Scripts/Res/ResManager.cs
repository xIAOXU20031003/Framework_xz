using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ResManager : Singleton<ResManager>
{
    public T LoadRes<T>(string resName) where T : Object
    {
        T res = Resources.Load<T>(resName);
        if (res is GameObject)
        {
            return GameObject.Instantiate(res);
        }
        else
            return res;
    }

    //异步加载资源的接口
    public void LoadResAsync<T>(string resName,UnityAction<T> callback) where T : Object
    {
        MonoManager.Instance.StartCoroutine(ReallyLoadRes<T>(resName, callback));
    }

    //真正的协同函数，用于加载资源
    IEnumerator ReallyLoadRes<T>(string resName,UnityAction<T> callback) where T : Object
    {
        ResourceRequest res = Resources.LoadAsync<T>(resName);
        yield return res;
        if(res.asset is GameObject)
            callback?.Invoke(GameObject.Instantiate(res.asset) as T);
        else
            callback?.Invoke(res.asset as T);
    }
}
