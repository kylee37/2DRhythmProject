using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn1 : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoteSpawning1());
    }

    void Spawn()
    {
        Instantiate(spawnPrefab, spawnTransform.transform.position, spawnTransform.transform.rotation);
    }

    private IEnumerator NoteSpawning1()
    {
        yield return null;
    }
}
