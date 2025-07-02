using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] float throwForce = 10f;// Projectile Throwing Force
    [SerializeField] GameObject throwObjPrefab;// What are we throwing
    [SerializeField] Transform spawnPoint; // point of spawning
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))

        {

            ThrowProj();
        
        }
        
    }

    void ThrowProj()

    {

        GameObject proj = Instantiate(throwObjPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody2D projRigidbody2D = proj.GetComponent<Rigidbody2D>();

        projRigidbody2D.AddForce(spawnPoint.right * throwForce, ForceMode2D.Impulse);
     
    
    }



}
