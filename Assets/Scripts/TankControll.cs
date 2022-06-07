using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControll : MonoBehaviour
{
    private Rigidbody _rb;
    private float _moveSpeed=4f;
    private float _rotateSpeed=2f;

  private  void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    
  private  void FixedUpdate()
    {
        Move();
        Rotate();
    }
   private void Move()
    {
        _rb.velocity = transform.forward * _moveSpeed * Input.GetAxis("Vertical");    
    }
  private  void Rotate()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotateSpeed,0);
    }
}
