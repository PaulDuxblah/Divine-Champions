using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public PlayerControl playerControl;
    float distanceFromTarget = 2;

    // Start is called before the first frame update
    void Start()
    {
        Color color = gameObject.GetComponent<Renderer>().material.color;
        color.a = 0.5f;
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControl.lockedTarget) {
            Destroy(gameObject);
            return;
        }

        Vector3 vectorBetweenPlayerAndLockedTargetNormalized = -playerControl.GetVector3BetweenPlayerAndLockedTarget().normalized;
        transform.position = playerControl.lockedTarget.transform.position + vectorBetweenPlayerAndLockedTargetNormalized * distanceFromTarget;
        transform.rotation = Quaternion.LookRotation(vectorBetweenPlayerAndLockedTargetNormalized.normalized);
        transform.rotation *= Quaternion.Euler(90, 0, 0); // Turn cylinder toward player

        transform.rotation *= Quaternion.Euler(0, 1, 0);
    }
}
