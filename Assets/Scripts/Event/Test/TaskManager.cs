using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.Instance.AddEventListener("MonsterDead",MonsterDeadDo);
    }

    public void MonsterDeadDo(object info)
    {
        Debug.Log("Task Do MonsterDead  " + (info as Monster).Name);
    }
    
    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener("MonsterDead",MonsterDeadDo);
    }
}
