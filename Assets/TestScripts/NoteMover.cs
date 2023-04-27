using UnityEngine;

// 이 스크립트는 생성된 노트를 움직입니다.
public class NoteMover : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }
}