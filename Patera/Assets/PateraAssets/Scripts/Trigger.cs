using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObj;

    void Start()
    {
        GameManager.isPlayed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Debug.Log("Recognized Ball");
            if (GameManager.isPlayed)
            {
                GameManager.isPlayed = false;
                GameManager.numThrows--;
            }
            else
            {
                GameManager.isPlayed = true;
            }
            Debug.Log(GameManager.isPlayed.ToString());
        }
    }
}
