using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            Quaternion desiredRotation = target.rotation;
            Quaternion smoothedRotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed);
            transform.rotation = smoothedRotation;
        }
    }
}
