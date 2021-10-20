using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public float speed;
    private PlayerController playerController;
    private Rigidbody2D enemyRb;
    private Transform Player;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb= GetComponent<Rigidbody2D>();
        Player= GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,Player.position ,speed*Time.deltaTime );
        if(Vector2.Distance(transform.position,Player.position)<3)
        {
            speed=2;
        }else if(Vector2.Distance(transform.position,Player.position)>3)
        {
            speed=5;
        }
        
    }
}
