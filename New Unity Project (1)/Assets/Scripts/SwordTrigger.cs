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
    //Enemies enemies;



    public float knockback;

    void Start()
    {
        
       //enemies = GameObject.FindGameObjectWithTag("Enemies").GetComponent<Enemies>();
        ObjectCollider = GetComponent<PolygonCollider2D>();
        ArmMelee = pivot.GetComponent<ArmMelee>();
        rb2d = GetComponent<Rigidbody2D>();
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

        if (enemyobj.transform.position.x < transform.position.x + 5)
        {
            knockback = -50;
        }
        else if (enemyobj.transform.position.x > transform.position.x - 3)
        {
            knockback = 50;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            float verticalknockback = (enemyobj.transform.position.y - transform.position.y) * 50;
            rb.AddForce(new Vector2(knockback, verticalknockback), ForceMode2D.Impulse);
            
        }
    }
}