using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    float speed;
    private PlayerController playerController;
    private Rigidbody2D enemyRb;
    private Transform Player;
    private GameObject playerobj;
    Animator animator;
    Transform enemy;
    Vector2 movement;
    BoxCollider2D enemybox;
    public bool enemyFacingRight;

    public int enemyHealth = 3;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerobj = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, Player.position) < 1)
        {
            speed = 0;
        }
        else if (Vector2.Distance(transform.position, Player.position) > 1)
        {
            speed = 3;
        }
        //Physics2D.IgnoreCollision(GetComponent<BoxCollider2D>(), enemybox);
        animator.SetFloat("Speed", speed);
        if (playerobj.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(-0.5170946f, 0.5170946f);
            enemyFacingRight = false;
        }
        else
        {
            transform.localScale = new Vector2(0.5170946f, 0.5170946f); //
            enemyFacingRight = true;
        }
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log(enemyHealth);
    }
}
