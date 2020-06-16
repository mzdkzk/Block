using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    private float _speed = 500.0f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rb.AddForce(
            new Vector3(Input.GetAxisRaw("Horizontal") * _speed, 0f, 0f),
            ForceMode.Impulse
        );
    }
}
