using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int enemiesToDefeat;

    //public GameObject[] player;
    public int playerhealth = 3;
    public int maxplayerhealth = 3;
    GameObject door;
    //GameObject spawnmanager;
    SpawnManager spawnManagerScript;

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameController");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");
        
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        //door = GameObject.FindGameObjectWithTag("Door");
        
        //Debug.Log("yo");
    }

    // Update is called once per frame
    void Update()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        spawnManagerScript = FindObjectOfType<SpawnManager>();
        enemiesToDefeat = level;
        Debug.Log(playerhealth);
        //EndGame();
        if (spawnManagerScript.enemiesdead == enemiesToDefeat && spawnManagerScript.level6 == false)
        {
            Destroy(door.gameObject);
            spawnManagerScript.enemiesdead = 0;
            Debug.Log("Hi");
            level++;
            playerhealth = maxplayerhealth;
        } 

        //Debug.Log(level);

    }
   
}
