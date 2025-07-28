using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntranceControl : MonoBehaviour
{
    private bool isPlayerInRange = false;


    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("E Ű �Էµ� - �̵� �Ǵ� �� ��ȯ");
            SceneManager.LoadScene("MiniGameScene");
            }
        
    }



    public GameObject interactionPopup; 
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("��ȣ�ۿ� ������ ������ �����߽��ϴ�!");
            isPlayerInRange = true;
            interactionPopup.SetActive(true); 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("��ȣ�ۿ� ������ �������� ������ϴ�!");
            isPlayerInRange = false;
            interactionPopup.SetActive(false); // �÷��̾ ����� �˾� ����
        }
    }
}

