using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int enemiesToDefeat;
    GameObject threehearts;
    GameObject twohearts;
    GameObject oneheart;
    GameObject fourhearts;

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
        fourhearts = GameObject.FindGameObjectWithTag("fourhearts");
        threehearts = GameObject.FindGameObjectWithTag("threehearts");
        twohearts = GameObject.FindGameObjectWithTag("twohearts");
        oneheart = GameObject.FindGameObjectWithTag("oneheart");
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
        if (playerhealth == 4)
        {
            fourhearts.SetActive(true);
            threehearts.SetActive(false);
            twohearts.SetActive(false);
            oneheart.SetActive(false);
        }
        if (playerhealth == 3)
        {
            fourhearts.SetActive(false);
            threehearts.SetActive(true);
            twohearts.SetActive(false);
            oneheart.SetActive(false);
        } else if (playerhealth == 2)
        {
            fourhearts.SetActive(false);
            threehearts.SetActive(false);
            oneheart.SetActive(false);
            twohearts.SetActive(true);
        } else if (playerhealth == 1)
        {
            fourhearts.SetActive(false);
            threehearts.SetActive(false);
            oneheart.SetActive(true);
            twohearts.SetActive(false);
        }

        //EndGame();
        if (spawnManagerScript.enemiesdead == enemiesToDefeat)
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
