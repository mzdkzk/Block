using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ball : MonoBehaviour
{
    private float _speed = 10.0f;
    private float _firstMagnitude;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(
            (Vector3.up + Vector3.right) * _speed,
            ForceMode.VelocityChange
        );
    }

    private void Update()
    {
        if (_firstMagnitude <= 0)
        {
            _firstMagnitude = _rb.velocity.magnitude;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        _rb.velocity = _firstMagnitude * _rb.velocity.normalized;
    }
}
