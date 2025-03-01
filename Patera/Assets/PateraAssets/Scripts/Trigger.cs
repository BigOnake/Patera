using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject gameObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ball Triggered!");
        
        /*if(other.GetComponent<CharacterController>() && other.gameObject == gameObj)
        {
            isTrig = true;
            gameObj.transform.position = new Vector3(0, 1, -10);
        }*/
    }
}
