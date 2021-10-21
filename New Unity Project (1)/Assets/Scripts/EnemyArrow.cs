using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArrow : MonoBehaviour
{

    private Transform Player;

    public float speed;
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //Invoke("DestroyProjectile", lifeTime);
        Vector2 SkeleDirection = transform.position;
        Vector2 PlayerDirection = Player.transform.position;
        Vector2 direction = PlayerDirection - SkeleDirection;
        transform.right = direction;
    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().Damage(1);
            Destroy(gameObject);

        }
        else if (other.gameObject.CompareTag("Props"))
        {
            Destroy(gameObject);
        }


    }
}
