using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn : MonoBehaviour
{
    public GameObject spawnPrefab;
    // Start is called before the first frame update
    void Start()
    {
        spawnPrefab.transform.position = transform.position;
        StartCoroutine(NoteSpawning());
    }

    void Spawn()
    {
        Instantiate(spawnPrefab);
    }

    private IEnumerator NoteSpawning()
    {
        Spawn();
        yield return new WaitForSeconds(9f);
        Spawn();
        yield return new WaitForSeconds(0.5f);
        Spawn();
        yield return new WaitForSeconds(0.5f);
        Spawn();
        yield return new WaitForSeconds(1f);
        Spawn();

    }
}
