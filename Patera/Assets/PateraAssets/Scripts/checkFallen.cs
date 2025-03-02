using UnityEngine;

public class checkFallen : MonoBehaviour
{
    public float tippingThreshold = 15.0f;

    // Update is called once per frame
    void Update()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        float angle = Vector3.Angle(rb.transform.up, Vector3.up);
        
        if(angle > tippingThreshold)
        {
            GameManager.score += 10;
            Destroy(gameObject);
        }
     }
}
