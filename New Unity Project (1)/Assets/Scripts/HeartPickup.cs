using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPickup : MonoBehaviour
{
    GameManager GameManager;
    GameObject door;
    
    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        door = GameObject.FindGameObjectWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.maxplayerhealth = 4;
            GameManager.level++;
            GameManager.playerhealth = GameManager.maxplayerhealth;
            Destroy(door.gameObject);
            Destroy(gameObject);
        }
    }
}
