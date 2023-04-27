using UnityEngine;
using System.Collections;

// 이 스크립트는 오디오 파일의 비트와 박자를 분석하여 리듬 게임의 정확성을 높입니다.
public class BeatDetector : MonoBehaviour
{
    public AudioClip musicClip;
    public int frequencyBands = 64;
    public float beatThreshold = 1.2f;
    public float beatCooldown = 0.5f;
    public delegate void BeatAction();
    public static event BeatAction OnBeat;

    private AudioSource audioSource;
    private float[] samples;
    private float[] spectrum;
    private float timeToNextBeat;
    private bool isCooldown;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.Play();

        samples = new float[frequencyBands];
        spectrum = new float[frequencyBands];
        isCooldown = false;
    }

    void Update()
    {
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
        float averageEnergy = CalculateAverageEnergy(spectrum);
        if (averageEnergy > beatThreshold && !isCooldown)
        {
            OnBeat?.Invoke();
            StartCoroutine(BeatCoolDown());
        }
    }

    private float CalculateAverageEnergy(float[] spectrum)
    {
        float sum = 0;
        for (int i = 0; i < spectrum.Length; i++)
        {
            sum += spectrum[i];
        }
        return sum / spectrum.Length;
    }

    IEnumerator BeatCoolDown()
    {
        isCooldown = true;
        yield return new WaitForSeconds(beatCooldown);
        isCooldown = false;
    }
}