using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmArcher : MonoBehaviour
{
    //float armlimit = 90f;
    public PlayerController playercontroller;
    GameObject arm;

    float scale = 0.9426498f;


    // Start is called before the first frame update
    void Start()
    {
        arm = GameObject.Find("ArchieRArm");
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 armPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - armPosition;
        transform.right = direction;
        Debug.Log(transform.localRotation.eulerAngles.z);

        if (transform.localRotation.eulerAngles.z < 90)
        {
            playercontroller.facingRight = true;
            
            arm.transform.localScale = new Vector2(scale, scale);
        }
        else
        {
            playercontroller.facingRight = false;
            arm.transform.localScale = new Vector2(-scale, scale);
            
        }
        if (transform.localRotation.eulerAngles.z > 270)
        {
            playercontroller.facingRight = true;
            arm.transform.localScale = new Vector2(scale, scale);
        }
    }
}
