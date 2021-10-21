using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, new Vector3(0f, 0f, 0f), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
