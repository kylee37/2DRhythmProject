using UnityEngine;
using System.Collections;

public class BeatGenerator : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject notePrefab;
    public float bpm = 120.0f;

    private float beatInterval;

    void Start()
    {
        // ��Ʈ ������ ����մϴ�. (�д� ��Ʈ ���� �ʴ� ��Ʈ ���� ��ȯ)
        beatInterval = 60.0f / bpm;

        // ����� ��� ����
        audioSource.Play();

        // ��Ʈ�� ���� ��Ʈ ���� �ڷ�ƾ ����
        StartCoroutine(SpawnNotes());
    }

    IEnumerator SpawnNotes()
    {
        while (audioSource.isPlaying)
        {
            // ��Ʈ �������� ���ϴ� ��ġ�� �����մϴ�.
            Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);

            // ���� ��Ʈ���� ���
            yield return new WaitForSeconds(beatInterval);
        }
    }
}