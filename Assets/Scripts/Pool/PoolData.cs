using System.Collections.Generic;
using UnityEngine;

public class PoolData : MonoBehaviour
{
    public GameObject fatherObj;
    public List<GameObject> poolList;

    public PoolData(GameObject obj, GameObject poolObj)
    {
        fatherObj = new GameObject(obj.name);
        fatherObj.transform.parent = poolObj.transform;
        
        poolList = new List<GameObject>();
        PushObj(obj);
    }

    public GameObject GetObj()
    {
        GameObject obj = null;
        //取出第一个
        obj = poolList[0];
        poolList.RemoveAt(0);
        //断开父子关系
        obj.transform.parent = null;
        return obj;
    }

    public void PushObj(GameObject obj)
    {
        obj.SetActive(false);
        poolList.Add(obj);
        obj.transform.parent = fatherObj.transform;
    }
}
