using UnityEngine;

public class checkFallen : MonoBehaviour
{
    public float tippingThreshold = 15.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        float angle = Vector3.Angle(rb.transform.up, Vector3.up);
        if(angle > tippingThreshold)
        {
            GameManager.score += 1;
            Debug.Log($"Scored Pin {GameManager.score}");
            Destroy(gameObject);
        }
     }
}
