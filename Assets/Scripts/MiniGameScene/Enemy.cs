
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnInterval = 2f;
    public Transform player; // �÷��̾� ����

    public float spawnMin = -3f;
    public float spawnMax = 3f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), Random.Range(1,3), spawnInterval);
    }

    void SpawnEnemy()
    {
        // ������ ����
        int index = Random.Range(0, enemyPrefabs.Length);
        GameObject prefab = enemyPrefabs[index];

        // ȭ�� ������ �ٱ� X ��ġ
        float spawnX = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0, 0)).x;

        // �÷��̾�� ���� Y ��ġ
        float spawnY = Random.Range(spawnMin, spawnMax);

        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
        Instantiate(prefab, spawnPos, Quaternion.identity);

    }

    public Vector2 range = new Vector2(5f, 3f);

    public Vector3 SetRandomPlace(Vector3 lastPos, int totalCount)
    {
        Vector3 newPos = lastPos;
        newPos.x += Random.Range(3f, 6f); // ���� ����
        newPos.y = Random.Range(-range.y, range.y);
        transform.position = newPos;
        return newPos;
    }
}