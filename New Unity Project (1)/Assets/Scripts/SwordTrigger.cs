using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    PolygonCollider2D ObjectCollider;
    ArmMelee ArmMelee;
    public GameObject pivot;
    Rigidbody2D rb2d;
    public GameObject enemyobj;
    bool wait = false;
    public float timermax = 15;
    public float timer;
    BoxCollider2D box;
    //Enemies enemyscript;
    //Enemies enemies;



    public float knockback;

    void Start()
    {
        timer = timermax;
       //enemies = GameObject.FindGameObjectWithTag("Enemies").GetComponent<Enemies>();
        ObjectCollider = GetComponent<PolygonCollider2D>();
        ArmMelee = pivot.GetComponent<ArmMelee>();
        rb2d = GetComponent<Rigidbody2D>();
        box = enemyobj.gameObject.GetComponent<BoxCollider2D>();
        //enemyscript = enemyobj.GetComponent<Enemies>();
    }

    // Update is called once per frame
    void Update()
    {
        //enemies = enemyobj.GetComponent<Enemies>();
        
        if (ArmMelee.swingingright == true || ArmMelee.swingingleft == true)
        {
            rb2d.simulated = true;
            ObjectCollider.isTrigger = true;
        }
        else
        {
            rb2d.simulated = false;
            ObjectCollider.isTrigger = false;
        }

        if (enemyobj.transform.position.x < transform.position.x)
        {
            knockback = -50;
        }
        else if (enemyobj.transform.position.x > transform.position.x)
        {
            knockback = 50;
        }
        //if (wait == true)
       // {
            ///timer -= 1;
            //if (timer <= 0)
           // {
             //   box.isTrigger = false;
             //   timer = timermax;
              //  wait = false;
            //}
        //}
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            //enemyscript.enemyHealth -= 1;
            Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
            //wait = true;
            float verticalknockback = (enemyobj.transform.position.y - transform.position.y) * 50;
            rb.AddForce(new Vector2(knockback, verticalknockback), ForceMode2D.Impulse);
            other.gameObject.GetComponent<EnemyHealth>().Damage(1);
            //box.isTrigger = true;
            Debug.Log("Hit");
        }
        if (other.gameObject.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
        }
    }
}