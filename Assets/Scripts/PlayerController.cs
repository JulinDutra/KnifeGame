using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int jumpHeight = 8;
    int jumpWidth = 2;
    public Rigidbody rb;
    Camera cam;

    float degreeStep = 180f;
    float followSpeed = 2f;
    Quaternion ownRotation;

    private float horizontal;
    private Quaternion startRotation;
    public float turnSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ownRotation = transform.rotation;

        startRotation = this.transform.rotation;

        cam = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount>0 || Input.GetMouseButtonDown(0))
        {
           
            Debug.Log("Tocou na tela.");
            Jump();
            Rotate();
        }
        if(transform.rotation.z < -75f  || (transform.rotation.z > 75f && transform.rotation.z < 15f))
        {
            
            Rotate();
        }
    }


    void Jump()
    {
        rb.velocity = new Vector3(jumpWidth, jumpHeight, 0);
    }

    void Rotate()
    {
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, ownRotation, Time.deltaTime * degreeStep * followSpeed);

        horizontal += Input.GetAxisRaw("Horizontal");
        Quaternion targetRotation = startRotation * Quaternion.AngleAxis(horizontal, Vector3.forward);
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, turnSpeed * Time.deltaTime);
    }
}
