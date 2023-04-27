using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDetecter : MonoBehaviour
{
    AudioSource myAudio;
    private bool musicStart = false;

    private void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!musicStart)
        {
            if (collision.CompareTag("Note"))
            {
                Debug.Log("À½¾Ç ½ÇÇà");
                myAudio.Play();
                musicStart = true;
            }
        }
    }
}
