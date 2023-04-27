using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class KoolLane3 : MonoBehaviour
{
    SpriteRenderer _spriteRenderer;
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _spriteRenderer.enabled = false;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            _spriteRenderer.enabled = true;
        }
        else
            _spriteRenderer.enabled = false;

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Debug.Log("Kool");
                Destroy(collision.gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}