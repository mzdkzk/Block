using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var target = (GameObject)Resources.Load("Target/TargetPrefab");
        var container = GameObject.Find("Container");
        
        for (int i = 0; i < 5; i++)
        {
            var x = (float)(i+0.5) * 2 - 5;
            var y = Random.Range(0f, 8f);
            var instance = Instantiate(target, new Vector3(x, y, 0f), Quaternion.identity);
            instance.transform.parent = container.transform;
        }
    }
}
