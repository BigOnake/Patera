using UnityEngine;

public class checkFallen : MonoBehaviour
{
    public float tippingForwardThreshold = 85.0f;
    public float tippingBackwardThreshold = 275.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{GameManager.score}");
        if(gameObject.transform.position.z >= tippingForwardThreshold || gameObject.transform.position.z >= tippingBackwardThreshold)
        {
            GameManager.score += 1;
            Debug.Log($"Scored Pin {GameManager.score}");
            Destroy(this);
        }
     }
}
