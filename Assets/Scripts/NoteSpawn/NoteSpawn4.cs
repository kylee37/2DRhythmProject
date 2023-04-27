using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawn4 : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Transform spawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NoteSpawning4());
    }

    void Spawn()
    {
        Instantiate(spawnPrefab, spawnTransform.transform.position, spawnTransform.transform.rotation);
    }

    private IEnumerator NoteSpawning4()
    {
        yield return null;
    }
}
