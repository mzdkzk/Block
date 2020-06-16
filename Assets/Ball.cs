using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float _speed = 20.0f;
    private float _firstMagnitude;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(
            (Vector3.up + Vector3.right) * _speed,
            ForceMode.VelocityChange
        );
    }

    void Update()
    {
        
    }
}
