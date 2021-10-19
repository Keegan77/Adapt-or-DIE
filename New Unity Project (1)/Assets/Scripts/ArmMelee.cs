using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMelee : MonoBehaviour
{
    public GameObject arm;
    public float rotationSpeed = 0;
    bool swinging = false;
    //bool justswung = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.rotation.z == 0) {

            
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 154.36f);
            swinging = true;
            Debug.Log("Test");
        }
        if (swinging == true)
        {
            
            //StartCoroutine("Swing");
            //transform.Rotate(new Vector3(0, 0, -1));
            if (transform.rotation.z <= 0) {
                swinging = false;
            }
        }

    }
    IEnumerator Swing()
    {
        Debug.Log("Hi");
        while (swinging == true) {
            transform.Rotate(new Vector3(0, 0, -1));
        }
        

        if (transform.eulerAngles.z == 0)
        {
            swinging = false;
            Debug.Log("Test2");
            yield return null;
        }
        
    }
}
 