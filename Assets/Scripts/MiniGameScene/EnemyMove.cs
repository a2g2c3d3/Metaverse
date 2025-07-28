using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float curveAmplitude = 1f;     // ���Ʒ� ��鸲 ��
    public float curveFrequency = 2f;     // ��鸲 �ӵ�

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
        // �⺻ ���� �̵� �ӵ� ����
        Vector2 velocity = _rigidbody.velocity;
        velocity.x = -moveSpeed;

        // Y ���� � �̵� �߰�
        float newY = baseY + Mathf.Sin((Time.time + timeOffset) * curveFrequency) * curveAmplitude;
        velocity.y = (newY - transform.position.y) / Time.fixedDeltaTime; // ��ġ ���̸� �ӵ��� �ݿ�

        _rigidbody.velocity = velocity;
    }
}