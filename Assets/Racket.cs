using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    private float _speed = 100.0f;
    private float _initY;
    private float _currentY;
    private bool _isAttacking;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _initY = transform.position.y;
    }

    void Update()
    {
        _rb.AddForce(
            transform.right * (Input.GetAxisRaw("Horizontal") * _speed),
            ForceMode.Impulse
        );
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
        _currentY = transform.position.y;
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            transform.position = new Vector3(transform.position.x, _currentY, 0);
        }
    }

    IEnumerator Attack()
    {
        if (_isAttacking) yield break;
        
        _isAttacking = true;
        _rb.AddForce(new Vector3(0f, 70f, 0f), ForceMode.VelocityChange);
        yield return new WaitForSeconds(0.3f);
        transform.position = new Vector3(transform.position.x, _initY, 0f);
        _isAttacking = false;
    }
}
