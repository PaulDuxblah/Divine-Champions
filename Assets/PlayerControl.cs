using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    PlayerInput inputs;
    public PlayerCamera playerCamera;
    public GameObject lightSpear;
    public float speed = 16f;
    public float jumpSpeed = 8f;
    public float gravity = 9.81f;

    Vector3 moveDirection;
    CharacterController characterController;
    Vector2 cameraControl = Vector2.zero;
    GameObject spear;

    private void Awake()
    {
        inputs = new PlayerInput();

        inputs.Player.LStick.performed += ctx => Move(ctx.ReadValue<Vector2>());
        inputs.Player.LStick.canceled += ctx => Move(Vector2.zero);

        inputs.Player.RStick.performed += ctx => cameraControl = ctx.ReadValue<Vector2>();
        inputs.Player.RStick.canceled += ctx => cameraControl = Vector2.zero;

        inputs.Player.A.started += ctx => Jump();
        inputs.Player.X.started += ctx => Attack();
    }

    private void OnEnable()
    {
        inputs.Player.Enable();
    }

    private void OnDisable()
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
        if (!characterController.isGrounded) {
            moveDirection.y -= gravity;
        }
        characterController.Move(moveDirection * Time.deltaTime);

        if (cameraControl != Vector2.zero) ControlCamera();
    }

    private void Move(Vector2 direction)
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

    private void ControlCamera()
    {
        playerCamera.Rotate(cameraControl);
    }

    private void Jump()
    {
        
    }

    private void Attack()
    {
        ThrowLightSpear();
    }

    private void ThrowLightSpear()
    {
        Instantiate(lightSpear, transform.position, transform.rotation);
        StartCoroutine(MakeSpearDisappear(0));
        StartCoroutine(DisablingAction(LightSpear.CHANNEL_DURATION + LightSpear.POSTACTION_LAG));
        StartCoroutine(MakeSpearReappear(LightSpear.CHANNEL_DURATION + LightSpear.DELAY_BEFORE_SPEAR_REAPPEARS));
    }

    private IEnumerator MakeSpearDisappear(float duration)
    {
        yield return new WaitForSeconds(duration);
        spear.GetComponent<Renderer>().enabled = false;
    }

    private IEnumerator MakeSpearReappear(float duration)
    {
        yield return new WaitForSeconds(duration);
        spear.GetComponent<Renderer>().enabled = true;
    }

    private IEnumerator DisablingAction(float duration)
    {
        OnDisable();
        yield return new WaitForSeconds(duration);
        OnEnable();
    }
}
