using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolLane2 : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    private void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            boxCollider2D.enabled = true;

        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            boxCollider2D.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            Debug.Log("Cool");
            Destroy(collision.gameObject);
        }
    }
}
