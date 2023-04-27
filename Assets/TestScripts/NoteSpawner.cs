using UnityEngine;

// 이 스크립트는 BeatDetector에서 발생하는 이벤트에 따라 노트를 생성합니다.
public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;

    void OnEnable()
    {
        BeatDetector.OnBeat += SpawnNote;
    }

    void OnDisable()
    {
        BeatDetector.OnBeat -= SpawnNote;
    }

    private void SpawnNote()
    {
        Instantiate(notePrefab, transform.position, Quaternion.identity);
    }
}