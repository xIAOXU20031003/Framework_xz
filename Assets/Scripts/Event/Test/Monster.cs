using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public string Name = "Boss";
    public int type = 1;
    // Start is called before the first frame update
    void Start()
    {
        MonsterDead(this);
    }

    public void MonsterDead(object info)
    {
        EventCenter.Instance.TriggerListener("MonsterDead",this);
        Debug.Log("MonsterDead");
    }
}
