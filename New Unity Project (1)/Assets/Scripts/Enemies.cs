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
    //public GameObject spawnmanager;
    SpawnManager spawnmanagerscript;

    public GameObject gamemanager;
    
    public bool enemyFacingRight;
    public float atktimermax = 15f;
    public float atktimer;
    GameManager gamemanagerscript;
    public int enemHealth = 3;
    // Start is called before the first frame update
    void Start()
    {
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");
        spawnmanagerscript = FindObjectOfType<SpawnManager>();
        enemyRb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerobj = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        atktimer = atktimermax;
        gamemanager = GameObject.Find("GameManager");
        gamemanagerscript = gamemanager.gameObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, Player.position) < 1)
        {
            speed = 0.1f;
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
        if (enemHealth <= 0)
        {
            spawnmanagerscript.enemiesdead += 1;
            //Debug.Log("Test");
            //Destroy(gameObject);
        }
        //Debug.Log(enemHealth);
    }
    public void Damage (int dmg)
    {
        enemHealth -= dmg;
    }
    public void DamagePlayer (int dmg)
    {
        //atktimer -= 1;
       // if (atktimer <= 0)
       // {
       //     gamemanager.gameObject.GetComponent<GameManager>().playerhealth -= dmg;
       //     atktimer = atktimermax;
      //  }
    }
    //private void OnCollisionStay(Collision2D other)
   // {
//
  //  }
    private void OnCollisionStay2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            atktimer -= 1;
            if (atktimer <= 0)
            {
                gamemanagerscript.playerhealth -= 1;
                atktimer = atktimermax;
                Debug.Log("ATTACKING");

            }
        }
    }
}
