using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    PlayerInput inputs;
    public PlayerCamera playerCamera;
    public GameObject lightSpear;
    public GameObject cursorPrefab;
    public GameObject cursor;
    GameObject spear;
    public float speed = 16f;
    public float jumpSpeed = 8f;
    public float gravity = 9.81f;

    Vector3 moveDirection;
    CharacterController characterController;
    Vector2 cameraControl = Vector2.zero;
    public GameObject lockedTarget = null;
    float lockedTargetMaxDistance = 100;

    private void Awake()
    {
        inputs = new PlayerInput();

        inputs.Player.LStick.performed += ctx => Move(ctx.ReadValue<Vector2>());
        inputs.Player.LStick.canceled += ctx => Move(Vector2.zero);

        inputs.Player.RStick.performed += ctx => cameraControl = ctx.ReadValue<Vector2>();
        inputs.Player.RStick.canceled += ctx => cameraControl = Vector2.zero;

        inputs.Player.A.started += ctx => Jump();
        inputs.Player.X.started += ctx => Attack();
        inputs.Player.LB.started += ctx => ToggleLockTarget();
    }

    void OnEnable()
    {
        inputs.Player.Enable();
    }

    void OnDisable()
    {
        inputs.Player.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        characterController.detectCollisions = false;

        spear = GameObject.Find("Spear");
    }

    // Update is called once per frame
    void Update()
    {
        if (!characterController.isGrounded) moveDirection.y -= gravity;
        characterController.Move(moveDirection * Time.deltaTime);

        if (cameraControl != Vector2.zero) ControlCamera();

        if (lockedTarget) {
            if (Vector3.Distance(lockedTarget.transform.position, transform.position) > lockedTargetMaxDistance) {
                UnlockTarget();
            } else {
                playerCamera.AlignWithLockedTarget(lockedTarget);
            }
        }
    }

    void Move(Vector2 direction)
    {
        if (direction.magnitude <= 0.15f) {
            moveDirection = Vector3.zero;
            return;
        }

        Vector2 directionNormalized = direction.normalized;
        float directionAngle = Mathf.Acos(directionNormalized.x) * Mathf.Rad2Deg;
        if (direction.y < 0) directionAngle *= -1;

        Vector2 cameraToPlayer = (new Vector2(transform.position.x, transform.position.z) - new Vector2(playerCamera.transform.position.x, playerCamera.transform.position.z)).normalized;
        float cameraToDefaultAngle = Vector2.Angle(cameraToPlayer, Vector2.up);
        if (cameraToPlayer.x > 0) cameraToDefaultAngle *= -1;

        float totalAngleRad = (cameraToDefaultAngle + directionAngle) * Mathf.Deg2Rad;

        direction = new Vector2(Mathf.Cos(totalAngleRad), Mathf.Sin(totalAngleRad));

        Vector3 direction3D = new Vector3(direction.x, 0, direction.y);

        if (characterController.isGrounded) {
            moveDirection = direction3D * speed;
        } else {

        }

        float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
    }

    void ControlCamera()
    {
        playerCamera.Rotate(cameraControl);
    }

    void Jump()
    {
        
    }

    void Attack()
    {
        ThrowLightSpear();
    }

    void ThrowLightSpear()
    {
        Quaternion throwDirection = transform.rotation;
        if (lockedTarget) {
            throwDirection = GetRotationTowardsLockedTargetForLightSpear();
            transform.rotation = throwDirection;
        }

        Instantiate(lightSpear, transform.position, throwDirection);
        StartCoroutine(MakeSpearDisappear(0));
        StartCoroutine(DisablingAction(LightSpear.CHANNEL_DURATION + LightSpear.POSTACTION_LAG));
        StartCoroutine(MakeSpearReappear(LightSpear.CHANNEL_DURATION + LightSpear.DELAY_BEFORE_SPEAR_REAPPEARS));
    }

    IEnumerator MakeSpearDisappear(float duration)
    {
        yield return new WaitForSeconds(duration);
        spear.GetComponent<Renderer>().enabled = false;
    }

    IEnumerator MakeSpearReappear(float duration)
    {
        yield return new WaitForSeconds(duration);
        spear.GetComponent<Renderer>().enabled = true;
    }

    IEnumerator DisablingAction(float duration)
    {
        OnDisable();
        yield return new WaitForSeconds(duration);
        OnEnable();
    }

    void ToggleLockTarget()
    {
        if (lockedTarget) {
            UnlockTarget();
            return;
        }

        List<Renderer> visibleRenderers = new List<Renderer>();
        Renderer[] sceneRenderers = FindObjectsOfType<Renderer>();
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        for (int i = 0; i < sceneRenderers.Length; i++) {
            if (sceneRenderers[i].gameObject.tag != "Enemy") continue;

            if ((GeometryUtility.TestPlanesAABB(planes, sceneRenderers[i].bounds))) visibleRenderers.Add(sceneRenderers[i]);
        }

        if (visibleRenderers.Count == 0) return;

        float closest = Vector3.Distance(visibleRenderers[0].gameObject.transform.position, transform.position);
        int closestIndex = 0;
        for (int i = 1; i < visibleRenderers.Count; i++) {
            float distance = Vector3.Distance(visibleRenderers[i].gameObject.transform.position, transform.position);
            if (distance < closest) {
                closest = distance;
                closestIndex = i;
            }
        }

        lockedTarget = visibleRenderers[closestIndex].gameObject;
        cursor = Instantiate(cursorPrefab);
        cursor.GetComponent<Cursor>().playerControl = this;
    }

    void UnlockTarget()
    {
        lockedTarget = null;
        Destroy(cursor);
    }

    public Vector3 GetVector3BetweenPlayerAndLockedTarget()
    {
        if (!lockedTarget) return Vector3.zero;
        return lockedTarget.transform.position - transform.position;
    }

    public Quaternion GetRotationTowardsLockedTarget()
    {
        if (!lockedTarget) return transform.rotation;
        return Quaternion.LookRotation(GetVector3BetweenPlayerAndLockedTarget(), Vector3.up);
    }

    public Quaternion GetRotationTowardsLockedTargetForLightSpear()
    {
        if (!lockedTarget) return transform.rotation;
        return GetRotationTowardsLockedTarget() * Quaternion.Euler(Vector3.up * -1);
    }
}
