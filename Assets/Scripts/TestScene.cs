using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene : MonoBehaviour
{
    public Staff staff;

    public void IdleButton()
    {
        staff.State = UnitState.Idle;
    }
    
    public void WalkButton()
    {
        staff.State = UnitState.Walk;
    }
}
