using UnityEngine;
using TMPro; // TextMeshPro를 사용하기 위해 이 줄을 추가해야 합니다.

public class ScoreManager : MonoBehaviour
{
   
    public TextMeshProUGUI scoreText;

    void Update()
    {
       
        scoreText.text = "Score: " + Player.score.ToString();


        if (Player.score >= 10)
        {
            scoreText.color = Color.yellow;
        }
        else
        {
            scoreText.color = Color.white; // 기본 색상으로 되돌리기
        }
    }
}