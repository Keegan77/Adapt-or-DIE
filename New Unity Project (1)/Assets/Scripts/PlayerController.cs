using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public bool facingRight;

    Rigidbody2D rb;
    Animator animator;
    GameObject arm;
    GameObject pivot;
    

    Vector2 movement;
    private void Start()
    {
        facingRight = true;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        arm = GameObject.Find("ArchieMArm");
        pivot = GameObject.Find("ArmPivot");


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
        if (transform.position.x > 10) {
            SceneManager.LoadScene(1);
        }

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
