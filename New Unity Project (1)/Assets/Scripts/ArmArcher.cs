using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmArcher : MonoBehaviour
{
    //float armlimit = 90f;
    public PlayerController playercontroller;
    GameObject arm;
    public GameObject projectile;

    float scale = 0.9426498f;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        arm = GameObject.Find("ArchieRArm");
    }
    // Update is called once per frame
    void Update()
    {
        ArcherFacing();

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    private void ArcherFacing()
    {
        Vector2 armPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - armPosition;
        transform.right = direction;
        //Debug.Log(transform.localRotation.eulerAngles.z);




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
