using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    public Vector3 gravity;
    public Vector3 jumpSpeed;

    bool isGrounded = false;

    public float horizontalInput;
    public float horizontalMultiplier;

    private void Awake()
    {
        Physics.gravity = gravity;
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
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
