using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMage : MonoBehaviour
{
    //float armlimit = 90f;
    public PlayerController playercontroller;
    GameObject arm;
    public GameObject projectileMage;

    float scale = 0.9426498f;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;
    float waittime = 1200;
    float minusfactor = 300;
    public float cooldown;
    public bool canShoot;

    // Start is called before the first frame update
    void Start()
    {
        arm = GameObject.Find("ArchieSArm");
        cooldown = waittime;
    }
    // Update is called once per frame
    void Update()
    {
        ArcherFacing();

        if (cooldown >= minusfactor && canShoot)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(projectileMage, shotPoint.position, transform.rotation);
                //timeBtwShots = startTimeBtwShots;
                cooldown -= minusfactor;
            }
        }
        else
        {
            cooldown++;
            canShoot = false;
        }
        if (cooldown >= waittime)
        {
            canShoot = true;
        }
        if (cooldown > waittime)
        {
            cooldown = waittime;
        }
        
        //Debug.Log(cooldown);
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