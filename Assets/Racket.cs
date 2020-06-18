using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    private float _speed = 1000.0f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var inputH = Input.GetAxisRaw("Horizontal");
        _rb.AddForce(
            new Vector3(inputH * _speed, 0f, 0f),
            ForceMode.Impulse
        );
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            other.rigidbody.AddForce(_rb.velocity, ForceMode.Impulse);
        }
    }
}
