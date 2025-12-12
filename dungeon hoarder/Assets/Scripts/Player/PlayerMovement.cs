using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public Rigidbody2D rb;
    public float jumpForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Get horizontal input
        float moveY = Input.GetAxisRaw("Vertical");   // Get vertical input
        Vector2 movement = new Vector2(moveX, moveY).normalized; // Create a normalized movement vector
        rb.velocity = movement * moveSpeed; // Set the player's velocity based on input and speed
        
        Camera.main.transform.position = new Vector3(rb.position.x, rb.position.y, -10f); // Follow the player with the camera

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed."); // jump action
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); // Apply an upward force to the player for jumping
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            Debug.Log("W key was released."); // move up
            transform.position += Vector3.up * Time.deltaTime * moveSpeed; // Move the player up by 1 unit on key release

        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S key is being held down."); // move down
            transform.position += Vector3.down * Time.deltaTime * moveSpeed; // Move the player down while key is held
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A key was pressed."); // move left
            transform.position += Vector3.left * Time.deltaTime * moveSpeed; // Move the player left on key press
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("D key was released."); // move right
            transform.position += Vector3.right * Time.deltaTime * moveSpeed; // Move the player right on key release
        }
    }
}
