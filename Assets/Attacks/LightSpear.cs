using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpear : MonoBehaviour
{
    public static float CHANNEL_DURATION = 0.3f;
    public static float POSTACTION_LAG = 0.25f;
    public static float DELAY_BEFORE_DESTROY = 10.0f;
    public static float DELAY_BEFORE_SPEAR_REAPPEARS = 0.75f;

    public Rigidbody rb;
    float speed = 120f;
    Vector3 throwDirection;

    void Awake()
    {
        rb.useGravity = false;
        rb.detectCollisions = false;
        throwDirection = transform.forward + new Vector3(0, 0.01f, 0);

        Vector3 pos = transform.rotation * new Vector3(1f, 1.5f, 0);
        
        transform.position += pos;
        transform.rotation *= Quaternion.Euler(90, 0, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Throw());
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.useGravity) {
            rb.AddForce(-Physics.gravity * Time.deltaTime / 4);
        }
    }

    IEnumerator Throw()
    {
        yield return new WaitForSeconds(CHANNEL_DURATION);
        rb.velocity = throwDirection * speed;
        rb.useGravity = true;
        rb.detectCollisions = true;
        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(DELAY_BEFORE_DESTROY);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == Enemy.TAG) {
            Enemy enemy = (Enemy) other.gameObject.GetComponent<Enemy>();
            enemy.hp -= 1;
        }

        Destroy(gameObject);
    }
}
