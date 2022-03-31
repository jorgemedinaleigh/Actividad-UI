using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    bool isOnGround = true;

    [SerializeField] float movementSpeed;
    [SerializeField] float jumpForce;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessMovement();
        ProcessJump();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    private void ProcessMovement()
    {
        if(!isOnGround)
        {
            float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * (movementSpeed - 2);
            transform.Translate(new Vector3(xPos, 0, 0));
        }
        else
        {
            float xPos = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
            transform.Translate(new Vector3(xPos, 0, 0));
        }        
    }

    private void ProcessJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
}
