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
    private MeshRenderer _mr;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.AddForce(
            (Vector3.up + Vector3.right) * _speed,
            ForceMode.VelocityChange
        );
        _mr = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (_firstMagnitude <= 0)
        {
            _firstMagnitude = _rb.velocity.magnitude;
        }

        if (GameController.State == GameState.Finish && _rb.velocity.magnitude > 0)
        {
            _rb.velocity = new Vector3(0, 0, 0);
        }

        var color = transform.position.y > 0 ? Color.black : Color.white;
        _mr.material.SetColor("_EmissionColor", color);
    }

    private void OnCollisionExit(Collision other)
    {
        _rb.velocity = _firstMagnitude * _rb.velocity.normalized;
    }
}
