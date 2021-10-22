using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int enemiesToDefeat;

    public GameObject[] player;
    public int playerhealth = 3;
    GameObject door;
    //GameObject spawnmanager;
    SpawnManager spawnManagerScript;

    // Start is called before the first frame update
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameController");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");
        spawnManagerScript = FindObjectOfType<SpawnManager>();
        if(objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        
        //Debug.Log("yo");
    }

    // Update is called once per frame
    void Update()
    {
        enemiesToDefeat = level;
        //EndGame();
        if (spawnManagerScript.enemiesdead == level)
        {
            Destroy(door.gameObject);
        }
        //Debug.Log(playerhealth);

    }
   
}
