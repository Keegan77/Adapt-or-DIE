using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{
    private Transform Player;
    public GameObject enemyArrow;
    public Transform shotpoint;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate()
        Instantiate(enemyArrow, shotpoint.position, transform.rotation);
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        if (1 == 1)
        {
            float timer = 30;
            timer -= 1;
            if (timer <= 0)
            {
                Instantiate(enemyArrow, shotpoint.position, transform.rotation);
                timer = 30;
            }
        }
        /*Vector2 SkeleDirection = transform.position;
        Vector2 PlayerDirection = Player.transform.position;
        Vector2 direction = PlayerDirection - SkeleDirection;
        transform.right = direction;*/
    }
}
