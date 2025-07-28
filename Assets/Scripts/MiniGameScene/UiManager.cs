using UnityEngine;
using TMPro; // TextMeshPro�� ����ϱ� ���� �� ���� �߰��ؾ� �մϴ�.

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
            scoreText.color = Color.white; // �⺻ �������� �ǵ�����
        }
    }
}