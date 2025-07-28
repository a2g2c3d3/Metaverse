using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float curveAmplitude = 1f;     // 위아래 흔들림 폭
    public float curveFrequency = 2f;     // 흔들림 속도

    private Rigidbody2D _rigidbody;
    private float baseY;
    private float timeOffset;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        baseY = transform.position.y;
        timeOffset = Random.Range(0f, 100f);
    }




    void FixedUpdate()
    {
        // 기본 왼쪽 이동 속도 설정
        Vector2 velocity = _rigidbody.velocity;
        velocity.x = -moveSpeed;

        // Y 방향 곡선 이동 추가
        float newY = baseY + Mathf.Sin((Time.time + timeOffset) * curveFrequency) * curveAmplitude;
        velocity.y = (newY - transform.position.y) / Time.fixedDeltaTime; // 위치 차이를 속도로 반영

        _rigidbody.velocity = velocity;
    }
}