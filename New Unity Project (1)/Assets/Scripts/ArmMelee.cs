using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMelee : MonoBehaviour
{
    
    float rotationSpeed = 1.5f;
    public bool swingingright = false;
    public bool swingingleft = false;
    public PlayerController PlayerController;
    private float timebtwshots;
    public float starttimebtwshots = 5;

    //bool justswung = false;
    // Start is called before the first frame update
    void Start()
    {

        //PlayerController = GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timebtwshots);
        if (timebtwshots <= 0)
        {
            timebtwshots = starttimebtwshots;

            if (Input.GetMouseButtonDown(0) && swingingleft == false && swingingright == false)
            {


                if (PlayerController.facingRight == true)
                {
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 154.36f);
                    swingingright = true;
                    //Debug.Log("Test");
                }
                else if (PlayerController.facingRight == false)
                {
                    transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, -154.36f);
                    swingingleft = true;
                    //Debug.Log("Test");
                }
            }
            if (swingingright == true)
            {

                //StartCoroutine("Swing");
                transform.Rotate(new Vector3(0, 0, -rotationSpeed));
                if (transform.rotation.z <= 0)
                {
                    swingingright = false;
                }
            }
            if (swingingleft == true)
            {

                //StartCoroutine("Swing");
                transform.Rotate(new Vector3(0, 0, -rotationSpeed));
                if (transform.rotation.z >= 0)
                {
                    swingingleft = false;
                }
                
                //Debug.Log("Hello");
            }
            
        } else timebtwshots -= Time.deltaTime;

    }
}
 