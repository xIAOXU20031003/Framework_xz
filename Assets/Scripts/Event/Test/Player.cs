using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventCenter.Instance.AddEventListener("MonsterDead",MonsterDeadDo);
    }

    public void MonsterDeadDo(object info)
    {
        Debug.Log("Player Do MonsterDead  " + (info as Monster).type);
    }

    private void OnDestroy()
    {
        EventCenter.Instance.RemoveEventListener("MonsterDead",MonsterDeadDo);
    }
}
