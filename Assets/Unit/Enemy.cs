using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static string TAG = "Enemy";
    public float hp = 1;

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        if (hp <= 0) {
            Destroy(gameObject);
        }
    }
}
