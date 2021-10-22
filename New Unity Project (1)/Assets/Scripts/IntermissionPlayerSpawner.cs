using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermissionPlayerSpawner : MonoBehaviour
{
    public int playstyle; // 0 = swordsman, 1 = archer, 2 = mage
    public GameObject[] playstyles;
    GameObject playerreal;
    // Start is called before the first frame update
    void Start()
    {
        playstyle = Random.Range(0, 3);
        Instantiate(playstyles[playstyle], new Vector3(-8.57f, 0.468f, 0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
