
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    private float noteSpeed = 16;
    [SerializeField] 
    private Vector3 moveDirection = Vector2.down;

    void Update()
    {
       transform.position += moveDirection * noteSpeed * Time.deltaTime;        
    }
}
