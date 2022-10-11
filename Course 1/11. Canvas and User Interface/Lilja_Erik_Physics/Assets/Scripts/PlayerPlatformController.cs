using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformController : MonoBehaviour
{
    public float speed;
    public float jumpPower = 10;

    //Reference to rigid body
    Rigidbody2D rb2d;

    Vector2 movement = new Vector2();

    bool grounded;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        movement.x = x * speed;

        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0); //Resets y speed before jump
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
        }

        movement.y = rb2d.velocity.y;
        rb2d.velocity = movement;
    }

    void OnTriggerEnter2D(Collider2D Ground)
    {
        grounded = true;
    }
    void OnTriggerExit2D(Collider2D Ground)
    {
        grounded = false;
    }
}
