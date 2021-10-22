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
    //lvl 8 vars
    float spawnrangeleftX8 = -1.79f;
    float spawnrangerightX8 = 1.69f;
    float spawnrangeY8 = 2.43f;
    //lvl 9 vars
    float spawnrangeleftX9 = 6.13f;
    float spawnrangerightX9 = 7.49f;
    float spawnrangeY9 = 2.4f;
    //lvl 10 vars
    float spawnrangerightX10 = 7.65f;
    float spawnrangeleftX10 = -2.96f;
    float spawnrangetopY10 = 3.69f;
    float spawnrangebotY10 = 3.108f
;    //
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
                
                if (sceneName != "Level 7" && sceneName != "Level 8" && sceneName != "Level 9" && sceneName != "Level 10" && sceneName != "Level 11")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn(), transform.rotation);
                }
                if (sceneName == "Level 7")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn7(), transform.rotation);
                }
                if (sceneName == "Level 8")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn8(), transform.rotation);
                }
                if (sceneName == "Level 9")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn9(), transform.rotation);
                }
                if (sceneName == "Level 10")
                {
                    enemychosen = Random.Range(0, 2);
                    Instantiate(enemy[enemychosen], GenerateEnemySpawn9(), transform.rotation);
                }

                level6 = false;
            }
        }

        playstyle = Random.Range(0, 3);
        Instantiate(playstyles[playstyle], new Vector3(-8.57f, 0.468f, 0), transform.rotation);


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
    private Vector3 GenerateEnemySpawn8()
    {
        float spawnPosX = Random.Range(spawnrangerightX8, spawnrangeleftX8);
        float spawnPosY = Random.Range(spawnrangeY8, -spawnrangeY8);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
    private Vector3 GenerateEnemySpawn9()
    {
        float spawnPosX = Random.Range(spawnrangerightX9, spawnrangeleftX9);
        float spawnPosY = Random.Range(spawnrangeY9, -spawnrangeY9);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
    private Vector3 GenerateEnemySpawn10()
    {
        float spawnPosX = Random.Range(spawnrangerightX10, spawnrangeleftX10);
        float spawnPosY = Random.Range(spawnrangetopY10, spawnrangebotY10);
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
