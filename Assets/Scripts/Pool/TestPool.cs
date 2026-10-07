using UnityEngine;

public class TestPool : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("0");
            PoolManager.GetInstance().GetObj("Prefabs/Cube");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("1");
            PoolManager.GetInstance().GetObj("Prefabs/Sphere");
        }
    }
}
