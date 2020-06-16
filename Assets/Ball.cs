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
            (transform.forward + transform.right) * _speed,
            ForceMode.VelocityChange
        );
    }

    void Update()
    {
        if (_firstMagnitude <= 0)
        {
            _firstMagnitude = _rb.velocity.magnitude;
        }
        Debug.Log(_rb.velocity.magnitude);
    }

    private void OnCollisionExit(Collision other)
    {
        _rb.velocity = _firstMagnitude * _rb.velocity.normalized;
    }
}
