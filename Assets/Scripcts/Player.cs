using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float x, y;
    private Rigidbody2D rb;
    private GameObject bullet;
    private GameObject boomEffect;

    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        bullet = (GameObject)Resources.Load("Prefabs/bullet");
        boomEffect = (GameObject)Resources.Load("Prefabs/boom");
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.velocity = transform.right * 5 * x + transform.up * 5 * y;
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(bullet, transform.position + 1.5f * transform.right, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(boomEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
