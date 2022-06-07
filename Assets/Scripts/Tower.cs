using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    private float _xPos;
    private float _yPos;
    private float _zPos;
    float sensityvyHorizont = 9f;
    private void Awake()
    {
       
    }

     
    private void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensityvyHorizont, 0);
    } 
    
}
