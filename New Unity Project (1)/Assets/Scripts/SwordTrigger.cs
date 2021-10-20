using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    PolygonCollider2D ObjectCollider;
    ArmMelee ArmMelee;
    public GameObject pivot;
    void Start()
    {
        ObjectCollider = GetComponent<PolygonCollider2D>();
        ArmMelee = pivot.GetComponent<ArmMelee>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ArmMelee.swingingright == true || ArmMelee.swingingleft == true)
        {
            ObjectCollider.isTrigger = true;
        }
        else ObjectCollider.isTrigger = false;
    }
}
