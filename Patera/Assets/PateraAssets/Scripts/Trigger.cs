using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObj;
    private static bool isPlayed;

    void Start()
    {
        isPlayed = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            Debug.Log("Recognized Ball");

            if(isPlayed)
            isPlayed = false;
            else
            isPlayed = true;

            Debug.Log(isPlayed.ToString());
        }
        
        GameManager.numThrows--;
    }
}
