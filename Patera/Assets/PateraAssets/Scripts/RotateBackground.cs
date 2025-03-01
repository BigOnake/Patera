using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    public Transform transform;
    public float xAxis, yAxis, zAxis;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(xAxis, yAxis, zAxis));
    }
}
