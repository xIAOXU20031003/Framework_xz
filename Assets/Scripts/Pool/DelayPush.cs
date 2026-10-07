using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayPush : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("PushObj",1.5f);
    }

    // Update is called once per frame
    void PushObj()
    {
        PoolManager.GetInstance().PushObj(this.gameObject.name,this.gameObject);
    }
}
