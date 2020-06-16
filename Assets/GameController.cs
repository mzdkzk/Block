using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    private readonly List<Target> _targets = new List<Target>();

    void Start()
    {
        var target = (GameObject) Resources.Load("Target/TargetPrefab");
        var container = GameObject.Find("Container");

        for (int i = 0; i < 5; i++)
        {
            var x = (float) (i + 0.5) * 2 - 5;
            var y = Random.Range(0f, 8f);
            var instance = Instantiate(target, new Vector3(x, y, 0f), Quaternion.identity);
            instance.transform.parent = container.transform;
            _targets.Add(
                instance.GetComponent<Target>()
            );
        }
    }

    private void Update()
    {
        if (IsFinished())
        {
            Debug.Log("クリア！");
        }
    }

    private bool IsFinished()
    {
        foreach (var target in _targets)
        {
            if (!target.IsLighting) return false;
        }
        return true;
    }
}
