using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static int currentFrame = 1;
    public static int currentRound = 1;
    int numThrows = 3;
    int score = 0;
    int minScore = currentRound * currentFrame * 100;

    bool winFrame = false;

    private PinSpawner ps;

    private void Awake()
    {
        Instance = this;

        PinSpawner.Instance.SpawnPins(currentRound);
    }

    void Update()
    {
        // When the frame is complete
        if (numThrows == 0)
        {
            if (score >= minScore)
            {
                winFrame = true;
                ContinueGame();
            }
        }
    }

    private void ContinueGame()
    {
        winFrame = false;
        numThrows = 3;

        if (currentFrame == 2)
            currentRound++;
            currentFrame = 1;
    }

    void FixedUpdate()
    {
        // Calculate if it was a valid throw
        // Check to see score
    }
}
