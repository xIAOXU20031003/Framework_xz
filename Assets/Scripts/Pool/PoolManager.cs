using System.Collections.Generic;
using UnityEngine;

public class PoolManager : SingletonMono<PoolManager>
{
    //缓存容器池
    public Dictionary<string,PoolData> poolDic = new Dictionary<string, PoolData>();

    private GameObject PoolObj;
    public GameObject GetObj(string name)
    {
        GameObject obj = null;
        //有抽屉 并且抽屉里面有东西
        if (poolDic.ContainsKey(name) && poolDic[name].poolList.Count > 0)
        {
            obj = poolDic[name].GetObj();
        }
        //没有东西就自己创建
        else
        {
            obj = GameObject.Instantiate(Resources.Load<GameObject>(name));
            obj.name = name;
        }
        obj.SetActive(true);
        return obj;
    }

    public void PushObj(string name, GameObject obj)
    {
        if(PoolObj == null)
            PoolObj = new GameObject("PoolObj");
        
        //有抽屉就放入
        if((poolDic.ContainsKey(name)))
        {
            poolDic[name].PushObj(obj);
        }
        //没有抽屉就创建
        else
        {
            PoolData poolData = new PoolData(obj, PoolObj);
            poolDic.Add(name, poolData);
            
        }
    }

    /// <summary>
    /// 清空缓存池 主要用于切换场景
    /// </summary>
    public void Clear()
    {
        poolDic.Clear();
        PoolObj = null;
    }
}
