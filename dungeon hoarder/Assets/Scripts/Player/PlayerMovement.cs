using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; 
    private Rigidbody rb;
    [SerializeField] private float jumpForce = 10f;
    private bool isGrounded = true; // check if player is on the ground
    [SerializeField] private bool canJump = false; // jump er slået til eller fra valg fri. 

    //[SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component attached to the player
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Get horizontal input
        float moveZ = Input.GetAxisRaw("Vertical");   // Get vertical input

        float yVelocity = rb.velocity.y;
        Vector3 movement = new Vector3(moveX, 0, moveZ).normalized;
        movement *= moveSpeed * Time.deltaTime;
        movement.y = yVelocity;
        rb.velocity = movement; // Set the player's velocity based on input and speed
       
        
        if(Input.GetKeyDown(KeyCode.Space) && canJump && isGrounded) 
        {
            rb.velocity = Vector3.up * jumpForce * Time.deltaTime; // Apply an upward force for jumping 
            isGrounded = false; 
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
