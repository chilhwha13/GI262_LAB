using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAnimetion : MonoBehaviour
{
    private Animator anim;
    private Staff staff;
    
    void Awake()
    {
        anim = GetComponent<Animator>();
        staff = GetComponent<Staff>();
    }
 
    // Update is called once per frame
    void Update()
    {
        if (staff.State == UnitState.Idle)
        {
            DisableAll();
            anim.SetBool("isIdle", true);
        }
 
        if (staff.State == UnitState.Walk)
        {
            DisableAll();
            anim.SetBool("isWalk", true);
        }
    }
 
    private void DisableAll()
    {
        anim.SetBool("isIdle", false);
        anim.SetBool("isWalk", false);
    }
}
