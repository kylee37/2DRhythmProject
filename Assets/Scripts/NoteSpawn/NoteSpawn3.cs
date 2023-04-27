using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn3 : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoteSpawning3());
    }

    void Spawn()
    {
        Instantiate(spawnPrefab, spawnTransform.transform.position, spawnTransform.transform.rotation);
    }

    private IEnumerator NoteSpawning3()
    {
        Spawn();
        yield return new WaitForSeconds(11f);
        Spawn();
        yield return new WaitForSeconds(1f);
        Spawn();
    }
}
