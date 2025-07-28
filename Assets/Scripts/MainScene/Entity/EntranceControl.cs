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
            Debug.Log("E 키 입력됨 - 이동 또는 씬 전환");
            SceneManager.LoadScene("MiniGameScene");
            }
        
    }



    public GameObject interactionPopup; 
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("상호작용 가능한 영역에 진입했습니다!");
            isPlayerInRange = true;
            interactionPopup.SetActive(true); 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("상호작용 가능한 영역에서 벗어났습니다!");
            isPlayerInRange = false;
            interactionPopup.SetActive(false); // 플레이어가 벗어나면 팝업 숨김
        }
    }
}

