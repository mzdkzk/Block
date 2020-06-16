using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    private float _accel = 1000.0f;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _rb.AddForce(
            transform.right * (Input.GetAxisRaw("Horizontal") * _accel),
            ForceMode.Impulse
        );
        if (Input.GetKey(KeyCode.Space))
        {
            _rb.AddForce(new Vector3(0f, 2f, 0f));
        }
    }
}