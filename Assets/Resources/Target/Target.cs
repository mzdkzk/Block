using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public bool IsLighting { get; private set; }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            GetComponent<Light>().enabled = true;
            IsLighting = true;
        }
    }
}
