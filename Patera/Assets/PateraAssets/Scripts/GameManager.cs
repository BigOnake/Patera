using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int currentFrame = 1;
    public static int currentRound = 1;
    public static int numThrows = 4;
    public static int score = 0;
    int minScore = currentRound * currentFrame * 1;

    public PinSpawner ps;

    void Awake()
    {
        Instance = this;

        ps.SpawnPins();
    }

    void Update()
    {
        // When the frame is complete
        if (numThrows == 0)
        {
            if (score >= minScore)
            {
                ContinueGame();
            }
            else
            {
                LoseGame();
            }
        }
    }

    void ContinueGame()
    {
        numThrows = 4;

        if (currentFrame % 2 == 0)
            currentRound++;
        currentFrame++;

        int minScore = currentRound * currentFrame * 1;
        score = 0;

        ps.DestroyPins();
        ps.SpawnPins();
    }

    void LoseGame()
    {
        numThrows = 4;
        currentFrame = 1;
        currentRound = 1;

        score = 0;
        int minScore = currentRound * currentFrame * 1;

        ps.DestroyPins();
        ps.SpawnPins();
    }
}
