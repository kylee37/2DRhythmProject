using UnityEngine;

// �� ��ũ��Ʈ�� ������ ��Ʈ�� �����Դϴ�.
public class NoteMover : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
    }
}