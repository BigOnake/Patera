using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int currentFrame = 1;
    public static int currentRound = 1;
    public static int numThrows = 3;
    public static int score = 0;

    public static bool isPlayed;
    int minScore = currentRound * currentFrame * 10;

    public PinSpawner ps;

    void Awake()
    {
        Instance = this;

        ps.SpawnPins();
    }

    void Update()
    {   
        if (!isPlayed && numThrows == 0)
        {
            if (score >= minScore)
            {
                Debug.Log("Going to continue");
                ContinueGame();
                Debug.Log("Done continue");
            }
            else
            {
                Debug.Log("Going to lose");
                LoseGame();
                Debug.Log("Lost is over.");
            }

            numThrows = 3;
            score = 0;
            minScore = currentRound * currentFrame * 10;

            ps.DestroyPins();
            ps.SpawnPins();
            ScoreUiUpdate.currentScore = 0;
        }
    }

    void ContinueGame()
    {
        if (currentFrame % 2 == 0)
            currentRound++;
        currentFrame++;
    }

    void LoseGame()
    {   
        numThrows = 3;
        currentFrame = 1;
        currentRound = 1;
    }
}
