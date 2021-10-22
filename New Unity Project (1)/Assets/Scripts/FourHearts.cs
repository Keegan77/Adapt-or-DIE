using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourHearts : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("fourhearts");
        //spawnmanager = GameObject.FindGameObjectWithTag("Spawner");

        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
