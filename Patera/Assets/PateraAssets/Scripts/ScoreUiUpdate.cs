using TMPro;
using UnityEngine;

public class ScoreUiUpdate : MonoBehaviour
{
    int currentScore;
    public TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentScore = GameManager.score;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.score > currentScore)
        {
            currentScore = GameManager.score;
            text.text = currentScore.ToString();
        }
    }
}
