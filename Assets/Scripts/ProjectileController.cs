using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    Rigidbody2D projRb;

     void Start()
    {
        projRb = GetComponent<Rigidbody2D>();
    }



     void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        projRb.velocity = Vector2.zero;
       // transform.parent = collision.transform;

    }



}
