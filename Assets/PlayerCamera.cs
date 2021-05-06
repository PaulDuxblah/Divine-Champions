using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    float yOffset = 5.0f;
    float zOffset = -25.0f;
    float cameraSpeed = 0.2f;
    Vector3 offset = Vector3.zero;
    float maxOffsetY = 15.0f;
    float minPositionY = 0f;
    
    public PlayerControl playerControl;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(playerControl.transform.position.x, playerControl.transform.position.y + yOffset, playerControl.transform.position.z + zOffset);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerControl.transform.position + offset;
        transform.LookAt(playerControl.transform.position);
    }

    public void Rotate(Vector2 direction)
    {
        if (direction.magnitude <= 0.1f) {
            return;
        }

        offset = Quaternion.AngleAxis(direction.x * cameraSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(-direction.y * cameraSpeed, Vector3.right) * offset;
    }
}
