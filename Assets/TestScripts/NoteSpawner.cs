using UnityEngine;

// �� ��ũ��Ʈ�� BeatDetector���� �߻��ϴ� �̺�Ʈ�� ���� ��Ʈ�� �����մϴ�.
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