using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    GameObject ballPrefab;
    private GameObject ball;
    Transform ballSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(ball.transform.position.y < -5)
        {
            Destroy(ball);
            Spawn();
        }
    }

    void Spawn()
    {
        ball = Instantiate(ballPrefab, ballSpawner.position, ballSpawner.rotation, null);
    }
}
