using UnityEngine;

public class checkFallen : MonoBehaviour
{
    public float tippingThreshold = 15.0f;
    public AudioClip soundFx;
    // Update is called once per frame

    void Update()
    {   
        Rigidbody rb = GetComponent<Rigidbody>();
        AudioSource box = GameObject.FindWithTag("Stereo").GetComponent<AudioSource>();
        float angle = Vector3.Angle(rb.transform.up, Vector3.up);
        soundFx = box.clip;

        if(angle > tippingThreshold)
        {
            Debug.Log(angle.ToString());
            GameManager.score += 10;
            box.PlayOneShot(soundFx);
            Destroy(gameObject);
        }
     }
}