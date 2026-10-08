using System.Collections;
using UnityEngine;

public class MonoTest1
{
    public MonoTest1()
    {
        MonoManager.Instance.StartCoroutine(Test123());
    }
    
    public void Update()
    {
        Debug.Log("Update");
    }

    IEnumerator Test123()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("IEnumerator");
    }
}

public class MonoTest : MonoBehaviour
{
    void Start()
    {
        MonoTest1 t = new MonoTest1();
        MonoManager.Instance.AddUpdateListener(t.Update);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
