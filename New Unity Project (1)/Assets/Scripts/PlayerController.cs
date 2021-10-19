using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public bool facingRight;

    public Rigidbody2D rb;
    public Animator animator;
    public GameObject arm;

    Vector2 movement;
    private void Start()
    {
        facingRight = true;
    }
    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.D))
        {
            facingRight = true;
        } else if (Input.GetKey(KeyCode.A))
        {
            facingRight = false;
        }
        animator.SetFloat("Speed", movement.sqrMagnitude);


    }
    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if (facingRight)
        {
            transform.localScale = new Vector2(0.5250514f, 0.5250514f); // i know the number is weird. it's the player's scale. go cry about it.
        }
        else if (!facingRight)
        {
            transform.localScale = new Vector2(-0.5250514f, 0.5250514f);
        }

    }
    
}
