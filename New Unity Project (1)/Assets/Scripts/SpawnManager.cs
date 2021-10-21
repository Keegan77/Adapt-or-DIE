using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;
    public int enemychosen; // 0 melee, 1 archer, 2 mage
    public float spawnrangeleftX = 0;
    public float spawnrangerightX = 5f;
    public float spawnrangeY = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            enemychosen = Random.Range(0, 2);
            Instantiate(enemy[enemychosen], GenerateEnemySpawn(), transform.rotation);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateEnemySpawn()
    {
        float spawnPosX = Random.Range(spawnrangerightX, spawnrangeleftX);
        float spawnPosY = Random.Range(spawnrangeY, -spawnrangeY);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        return randomPos;
    }
}
