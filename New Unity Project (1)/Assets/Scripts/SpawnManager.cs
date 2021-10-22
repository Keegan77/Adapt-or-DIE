using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;
    public int enemychosen; // 0 melee, 1 archer, 2 mage
    public float spawnrangeleftX = 0;
    public float spawnrangerightX = 5f;
    public float spawnrangeY = 3.5f;
    //lvl 7 vars
    public float spawnrangeleftX7 = 5;
    public float spawnrangerightX7 = 7.7f;
    public float spawnrangeY7 = 2.38f;
    //
    public GameObject gamemanager;
    GameManager gamemanagerscript;
    public int enemiesdead;
    GameObject door;

    public int playstyle; // 0 = swordsman, 1 = archer, 2 = mage
    public GameObject[] playstyles;
    GameObject playerreal;
    public bool level6;
    public bool level7;

    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.FindGameObjectWithTag("Door");
        gamemanager = GameObject.Find("GameManager");
        gamemanagerscript = gamemanager.GetComponent<GameManager>();
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        Debug.Log(sceneName);

        if (sceneName != "IntermissionCheckpoint6" )
        {
            for (int i = 0; i < gamemanagerscript.level; i++)
            {
                
                if (sceneName != "Level 7")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn(), transform.rotation);
                }
                if (sceneName == "Level 7")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn7(), transform.rotation);
                }

                level6 = false;
            }
        }

        playstyle = Random.Range(0, 3);
        Instantiate(playstyles[1], new Vector3(-8.57f, 0.468f, 0), transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(enemiesdead);
        EndGame();
    }
    private Vector3 GenerateEnemySpawn()
    {
        float spawnPosX = Random.Range(spawnrangerightX, spawnrangeleftX);
        float spawnPosY = Random.Range(spawnrangeY, -spawnrangeY);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
    private Vector3 GenerateEnemySpawn7()
    {
        float spawnPosX = Random.Range(spawnrangerightX7, spawnrangeleftX7);
        float spawnPosY = Random.Range(spawnrangeY7, -spawnrangeY7);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
    private void EndGame()
    {
        if (gamemanagerscript.playerhealth <= 0)
        {
            switch (playstyle)
            {
                case 0:
                    playerreal = GameObject.Find("Archie(Clone)");
                    Destroy(playerreal);
                    break;
                case 1:
                    playerreal = GameObject.Find("ArchieArcher 1(Clone)");
                    Destroy(playerreal);
                    break;
                case 2:
                    playerreal = GameObject.Find("ArchieMage(Clone)");
                    Destroy(playerreal);
                    break;
            }

        }
    }
}
