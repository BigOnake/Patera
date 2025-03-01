using UnityEngine;

public class ballDrag : MonoBehaviour
{   
    public float dragFactor = 0.5f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(rb.useGravity == true)
        {
            Vector3 velocity = rb.linearVelocity;
            float dragForceMagnitude = velocity.magnitude * velocity.magnitude * dragFactor;
            Vector3 drageForce = -velocity.normalized * dragForceMagnitude;

            rb.AddForce(drageForce, ForceMode.Force);
        }
        
    }
}
