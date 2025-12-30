using System;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public float jumpHeight = 5f;
    
    private float movment;
    public float moveSpeed = 6f;
    private bool facingRight = true;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       movment = Input.GetAxis("Horizontal");
       if (movment < 0f && facingRight) {
           transform.eulerAngles = new Vector3(0f, -180f, 0f);
           facingRight = false;
       } else if (movment > 0f && facingRight == false) {
           transform.eulerAngles = new Vector3(0f, 0f, 0f);
           facingRight = true;
       }

       if (input.GetKey(KeyCode.Space)) {
           jump();
       }

    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(movment, 0f, 0f) * Time.fixedDeltaTime * moveSpeed;
    }

    void jump() {
        rb.AddForce(new Vector2(0f, jumpHeight ), ForceMode2D.Impulse);
    }
    
    
}
