using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int enemiesToDefeat;
    public int playstyle; // 0 = swordsman, 1 = archer, 2 = mage
    public GameObject[] playstyles;
    // Start is called before the first frame update
    void Start()
    {
        enemiesToDefeat = level;
        playstyle = Random.Range(1, 3);
        Debug.Log(playstyle);
        Instantiate(playstyles[0], new Vector3(-8.57f, 0.468f, 0), transform.rotation);
        Debug.Log("yo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
