using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProps : MonoBehaviour // this is the most inefficient fucking way i could've written this code, but i don't care. it's a game jam. fuck you
{
    public GameObject[] props;
    public float spawnrangequad1X = -7.04f;// -1
    public float spawnrangeTopHalfY = 3.6f; // 2 is the Y barrier
    
    public float spawnrangequad2X = 1.06f; // 7.07
    
    public float spawnrangequad3Y = -2.13f; // -1.78

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(props[Random.Range(0, 4)], GenerateSpawnPosition1(), transform.rotation);
        Instantiate(props[Random.Range(0, 4)], GenerateSpawnPosition2(), transform.rotation);
        Instantiate(props[Random.Range(0, 4)], GenerateSpawnPosition3(), transform.rotation);
        Instantiate(props[Random.Range(0, 4)], GenerateSpawnPosition4(), transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPosition1()
    {
        float spawnPosX = Random.Range(spawnrangequad1X, -1);
        float spawnPosY = Random.Range(spawnrangeTopHalfY, 3);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        Debug.Log(randomPos);
        return randomPos;
        
    }
    private Vector3 GenerateSpawnPosition2()
    {
        float spawnPosX = Random.Range(spawnrangequad2X, 7.07f);
        float spawnPosY = Random.Range(spawnrangeTopHalfY, 3);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        Debug.Log(randomPos);
        return randomPos;
    }

    private Vector3 GenerateSpawnPosition3()
    {
        float spawnPosX = Random.Range(spawnrangequad1X, -1);
        float spawnPosY = Random.Range(spawnrangequad3Y, -1.78f);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        Debug.Log(randomPos);
        return randomPos;
    }

    private Vector3 GenerateSpawnPosition4()
    {
        float spawnPosX = Random.Range(spawnrangequad2X, 7.07f);
        float spawnPosY = Random.Range(spawnrangequad3Y, -1.78f);
        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);
        Debug.Log(randomPos);
        return randomPos;
    }
}

