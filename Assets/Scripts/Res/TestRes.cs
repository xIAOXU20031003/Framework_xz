using UnityEngine;

public class TestRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ResManager.Instance.LoadRes<GameObject>("Prefabs/Cube");
        }
        if (Input.GetMouseButtonDown(1))
        {
            ResManager.Instance.LoadResAsync<GameObject>("Prefabs/Cube", (obj) =>
            {
                //资源加载完成之后要做的事情
                obj.transform.localScale *= 2;
            });
        }
    }
}
