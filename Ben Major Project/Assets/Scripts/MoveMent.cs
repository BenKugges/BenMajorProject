using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveMent : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    float horizontalInput;
    float forwardInput;
    public bool isOnGround = true;
    Vector3 moveDirection;
    Rigidbody Rb;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {

        MovePlayer();
    }

    void Update()
    {
        MyInput();
    }
    
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //Calculates Movement Direction
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * forwardInput);

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            Rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }




    }
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
