using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    float yOffset = 5.0f;
    float zOffset = -25.0f;
    float cameraSpeed = 0.2f;
    Vector3 offset = Vector3.zero;
    Vector3 targetLockShift = new Vector3(2, 5, 5);
    float maxOffsetY = 15.0f;
    float minPositionY = 0f;
    
    public PlayerControl playerControl;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        ResetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerControl.transform.position + offset;
        transform.LookAt(playerControl.transform.position);
    }

    public float getOffsetLength()
    {
        return Mathf.Sqrt(Mathf.Pow(yOffset, 2) + Mathf.Pow(zOffset, 2));
    }

    public void Rotate(Vector2 direction)
    {
        if (direction.magnitude <= 0.1f) return;

        offset = Quaternion.AngleAxis(direction.x * cameraSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(-direction.y * cameraSpeed, Vector3.right) * offset;
    }

    public void AlignWithLockedTarget(GameObject lockedTarget)
    {
        Vector3 vectorBetweenPlayerAndLockedTarget = playerControl.GetVector3BetweenPlayerAndLockedTarget();
        Vector3 cameraAlignementDirection = -vectorBetweenPlayerAndLockedTarget.normalized;
        Quaternion rotation = playerControl.GetRotationTowardsLockedTarget();
        offset = (cameraAlignementDirection * getOffsetLength()) + rotation * targetLockShift;
    }

    public void ResetPosition()
    {
        offset = playerControl.transform.rotation * new Vector3(0, yOffset, zOffset);
    }
}
