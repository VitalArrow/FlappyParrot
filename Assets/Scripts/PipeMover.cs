using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMover : MonoBehaviour
{

    [SerializeField] float speed = 2f;
    [SerializeField] float coordToDestroy = -15f;



    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
   

    if (transform.position.x < coordToDestroy) // 1 reshenie
     {
         Destroy(gameObject);
     }
}
}

/*
 
void OnTriggerEnter2D (Collider2D collision)

{

Destroy (GameObject)
}

 */