using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn2 : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoteSpawning2());
    }

    void Spawn()
    {
        Instantiate(spawnPrefab, spawnTransform.transform.position, spawnTransform.transform.rotation);
    }

    private IEnumerator NoteSpawning2()
    {
        yield return new WaitForSeconds(11.5f);
        Spawn();
    }
}
