using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BgLooper : MonoBehaviour
{
    public int numBgCount = 5;


    void Start()
    {

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered: " + collision.name);

        if (collision.CompareTag("BackGround"))
        {
            float widthOfBgObject = ((BoxCollider2D)collision).size.x;
            Vector3 pos = collision.transform.position;

            pos.x += widthOfBgObject * numBgCount;
            collision.transform.position = pos;
            return;
        }

        // �浹�� ������Ʈ�� �±װ� "Enemy"���� Ȯ��
        if (collision.CompareTag("Enemy"))
        {
            // "Enemy" �±׸� ���� ������Ʈ�� ����
            Destroy(collision.gameObject);
            Debug.Log(collision.name + " (Enemy) ������Ʈ�� �����Ǿ����ϴ�.");
        }
      
    }
}