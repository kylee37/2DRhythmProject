using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            Debug.Log("Miss");
            Destroy(collision.gameObject);
        }
    }
}
