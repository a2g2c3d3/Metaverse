
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnInterval = 2f;
    public Transform player; // 플레이어 연결

    public float spawnMin = -3f;
    public float spawnMax = 3f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), Random.Range(1,3), spawnInterval);
    }

    void SpawnEnemy()
    {
        // 프리팹 선택
        int index = Random.Range(0, enemyPrefabs.Length);
        GameObject prefab = enemyPrefabs[index];

        // 화면 오른쪽 바깥 X 위치
        float spawnX = Camera.main.ViewportToWorldPoint(new Vector3(1.1f, 0, 0)).x;

        // 플레이어보다 위쪽 Y 위치
        float spawnY = Random.Range(spawnMin, spawnMax);

        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);
        Instantiate(prefab, spawnPos, Quaternion.identity);

    }

    public Vector2 range = new Vector2(5f, 3f);

    public Vector3 SetRandomPlace(Vector3 lastPos, int totalCount)
    {
        Vector3 newPos = lastPos;
        newPos.x += Random.Range(3f, 6f); // 간격 조절
        newPos.y = Random.Range(-range.y, range.y);
        transform.position = newPos;
        return newPos;
    }
}