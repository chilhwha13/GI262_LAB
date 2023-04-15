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
            anim.SetBool("IsIdle", true);
        }
 
        if (staff.State == UnitState.Walk)
        {
            DisableAll();
            anim.SetBool("IsWalk", true);
        }
    }
 
    private void DisableAll()
    {
        anim.SetBool("IsIdle", false);
        anim.SetBool("IsWalk", false);
    }
}
