using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float upForce = 200f;

    //int score = 0;
    Rigidbody2D birdRigidBody2D;
    bool isDead; // false on default
    public float tiltSmooth = 4f;
    public float maxTiltAngle = 30f;
    public float minTiltAngle = -30f;


    void Start()
    {

        birdRigidBody2D = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0) && !isDead)
        {

            birdRigidBody2D.velocity = Vector2.zero;// zeroing the USKORENIE
            birdRigidBody2D.AddForce(new Vector2(0, upForce));// Zadaiutsea USKORENIE
        }
        float tiltAngle;

        if (birdRigidBody2D.velocity.y > 0)
        {
            tiltAngle = maxTiltAngle;

        }
        else
        {

            tiltAngle = minTiltAngle;
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, 0f, tiltAngle), tiltSmooth * Time.deltaTime);
        //transform.eulerAngles = Vector3.Lerp (transform.eulerAngles, new Vector3 (0f, 0f, tiltAngle), tiltSmooth * Time.deltaTime);



    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isDead)
        {
            isDead = true;
            transform.rotation = Quaternion.Euler(0f, 0f, minTiltAngle);
            birdRigidBody2D.velocity = Vector2.zero;

        }
    }
}
    
/* - LOOK for the PICTURE!!!!
 * 
 * 
 * 
 * 
 * 
// 1- Интерполяция движения - изменение движения торможение/ускорениее
  
  Линейная:
  Vector startPos = new Vector3 (0f,0f,0f);
  Vector endPosition = new Vector3 (10f,10f,0f);
  float moveTime = 3f;
  float elapseTime = 0f;
  
  void Update()
  {
 elapsedTime = elapsedTime + Time.deltaTime;
  transform.position = Vector3.Lerp (startPos, endPosition, elapsedTime/moveTime);

  }
  
//2 - SmoothDamp (плавность движения, ограничение макимальной скорости)

Vector3 targetPosition = new Vector3 (10f, 10f, 0f);
Vector3 velocity = Vector3.zero;
float smoothTime = 3f;
maxSpeed = Mathf.Infinity; / maximum number

void Update()
{
transform.position = Vector3.SmoothDamp (transform.position, targetPosition, ref velocity, smoothTime, maxSpeed, float deltaTime = Time.deltaTime) / - last two argumentss are optional

}

//3 Slerp - Smooth Lerp


void Update ()

{
Quaternion targetRotation = Quaternio.LookRotation (Vector3.left);
transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, time.deltaTime)

}

//4 Rotation - поворот людей за машиной - default turned to right (tower defence games)


Vector3 target = new Vector3 (10f, 10f, 0f);

void Update ()
{

transform.LookAt (target);

}
  
//5 - character controller
//6 - Nav Mesh
  
  */