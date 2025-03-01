using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball Triggered!");
        GameManager.numThrows--;
        Debug.Log(GameManager.numThrows.ToString());
    }
}
