using UnityEngine;

public class PlayerFlightController : MonoBehaviour
{
    public float forwardSpeed = 25f;
    public float turnSpeed = 3.5f;
    public float rollSpeed = 3f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input
        float pitchInput = Input.GetAxis("Vertical");
        float yawInput = Input.GetAxis("Horizontal");
        float rollInput = Input.GetAxis("Mouse X"); // Or a new Input Axis "Roll"

        // Pitch
        transform.Rotate(pitchInput * turnSpeed * Time.deltaTime, 0, 0);

        // Yaw
        transform.Rotate(0, yawInput * turnSpeed * Time.deltaTime, 0, Space.World);

        // Roll
        transform.Rotate(0, 0, -rollInput * rollSpeed * Time.deltaTime);

        // Forward Movement
        rb.velocity = transform.forward * forwardSpeed;
    }
}
