using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = "Items collected: " + score;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Items collected: " + score;
    }
}
