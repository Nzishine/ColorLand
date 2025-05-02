using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    [Header("Target Settings")]
    public Transform target;
    public bool autoSetOffset = true;
    public Vector3 positionOffset = new Vector3(0f, 2f, -5f);
    public bool followRotation = true;

    [Header("Smoothing Settings")]
    [Range(0f, 1f)] public float positionSmoothTime = 0.1f;
    [Range(0f, 1f)] public float rotationSmoothTime = 0.05f;

    private Vector3 currentVelocity;
    private float currentRotationVelocity;

    private void Start()
    {
        if (autoSetOffset && target != null)
        {
            positionOffset = transform.position - target.position;
        }
    }

    private void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("Camera target is not assigned!");
            return;
        }

        FollowPosition();
        
        if (followRotation)
        {
            FollowRotation();
        }
    }

    private void FollowPosition()
    {
        Vector3 targetPosition = target.position + positionOffset;
        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPosition,
            ref currentVelocity,
            positionSmoothTime
        );
    }

    private void FollowRotation()
    {
        float targetRotationY = target.eulerAngles.y;
        float currentRotationY = Mathf.SmoothDampAngle(
            transform.eulerAngles.y,
            targetRotationY,
            ref currentRotationVelocity,
            rotationSmoothTime
        );
        
        transform.rotation = Quaternion.Euler(
            transform.eulerAngles.x,
            currentRotationY,
            transform.eulerAngles.z
        );
    }
}