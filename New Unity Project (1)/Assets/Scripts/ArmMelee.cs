using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMelee : MonoBehaviour
{
    public float rotationSpeed = 0;
    public bool swingingright = false;
    public bool swingingleft = false;
    public PlayerController PlayerController;
    //bool justswung = false;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && swingingleft == false && swingingright == false)
        {

            if (PlayerController.facingRight == true)
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 154.36f);
                swingingright = true;
                Debug.Log("Test");
            }
            else if (PlayerController.facingRight == false)
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -154.36f);
                swingingleft = true;
                Debug.Log("Test");
            }
        }
        if (swingingright == true)
        {

            //StartCoroutine("Swing");
            transform.Rotate(new Vector3(0, 0, -1));
            if (transform.rotation.z <= 0)
            {
                swingingright = false;
            }
        }
        if (swingingleft == true)
        {

            //StartCoroutine("Swing");
            transform.Rotate(new Vector3(0, 0, -1));
            if (transform.rotation.z >= 0)
            {
                swingingleft = false;
            }
            Debug.Log("Hello");
        }

    }
}
 