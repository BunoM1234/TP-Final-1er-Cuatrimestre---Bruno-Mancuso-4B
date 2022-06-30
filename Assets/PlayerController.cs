using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed;
    public float rotationSpeed;
    public Vector3 gravity;
    public Vector3 jumpSpeed;
    public GameObject camara;

    bool isGrounded = false;
    Rigidbody rb;

    public GameObject jugador;

    float CamaraY = 5.07f;
    float CamaraX = -3.43f;

    void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = jumpSpeed;
            isGrounded = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
       
       isGrounded = true;
        
    }
}
