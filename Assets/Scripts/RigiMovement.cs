using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigiMovement : MonoBehaviour
{
    //public float speedMovement = 5;
    public float jumpForce = 10;
    //public float groundDetectionDistance = 1;
    public Rigidbody2D rB;
    //public LayerMask groundLayer;


    void Start()
    {
        rB = GetComponent<Rigidbody2D>();    
    }
/*

    private void FixedUpdate()
    {
        Movement();
        if (Input.GetAxisRaw("Jump") == 1 && Physics.Raycast(transform.position, Vector3.down, groundDetectionDistance, groundLayer))
            Jump();
    }
    public void Movement()
    {
        Vector3 movVector = new Vector3(Input.GetAxisRaw("Horizontal") * speedMovement * Time.fixedDeltaTime, rB.velocity.y, Input.GetAxisRaw("Vertical") * speedMovement * Time.fixedDeltaTime);
        if (Physics.Raycast(transform.position, Vector3.down, groundDetectionDistance, groundLayer))
            rB.velocity = movVector;
    }
*/
    public void Jump()
    {
        rB.velocity = new Vector2(0,0); 
        rB.AddForce(Vector2.up *jumpForce * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
