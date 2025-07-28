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

        // 충돌한 오브젝트의 태그가 "Enemy"인지 확인
        if (collision.CompareTag("Enemy"))
        {
            // "Enemy" 태그를 가진 오브젝트를 삭제
            Destroy(collision.gameObject);
            Debug.Log(collision.name + " (Enemy) 오브젝트가 삭제되었습니다.");
        }
      
    }
}