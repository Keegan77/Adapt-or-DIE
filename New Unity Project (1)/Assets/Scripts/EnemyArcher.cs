using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{
    private Transform Player;
    GameObject playerobj;
    public GameObject enemyArrow;
    public Transform shotpoint;
    float timer = 1500;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate()
        //Instantiate(enemyArrow, shotpoint.position, transform.rotation);
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerobj = GameObject.FindGameObjectWithTag("Player");


    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;
        if (timer <= 0)
        {
            Instantiate(enemyArrow, shotpoint.position, transform.rotation);
            timer = 1500;
        }
        if (playerobj.transform.position.x < transform.position.x)
        {
            transform.localScale = new Vector2(-0.5170946f, 0.5170946f);
        }
        else
        {
            transform.localScale = new Vector2(0.5170946f, 0.5170946f); //
        }

        /*Vector2 SkeleDirection = transform.position;
        Vector2 PlayerDirection = Player.transform.position;
        Vector2 direction = PlayerDirection - SkeleDirection;
        transform.right = direction;*/
    }
}
