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
        // 비트 간격을 계산합니다. (분당 비트 수를 초당 비트 수로 변환)
        beatInterval = 60.0f / bpm;

        // 오디오 재생 시작
        audioSource.Play();

        // 비트에 따라 노트 생성 코루틴 실행
        StartCoroutine(SpawnNotes());
    }

    IEnumerator SpawnNotes()
    {
        while (audioSource.isPlaying)
        {
            // 노트 프리팹을 원하는 위치에 생성합니다.
            Instantiate(notePrefab, new Vector3(0, 10, 0), Quaternion.identity);

            // 다음 비트까지 대기
            yield return new WaitForSeconds(beatInterval);
        }
    }
}