using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int enemHealth = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemHealth <= 0)
        {
            Destroy(gameObject);
        }

    }

    public void Damage(int dmg)
    {
        enemHealth -= dmg;
    }
}
