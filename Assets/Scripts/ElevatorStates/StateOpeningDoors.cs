﻿using UnityEngine;
using System.Collections;

public class StateOpeningDoors : ElevatorState
{

    public override void UpdateState(GameObject gameObject)
    {

    }

    // Check if state is done with whatever it is doing
    public override bool IsStateDone()
    {
        return true;
    }

    // We have reached the end of the state and would like to transition to next state in line
    public override void EndState()
    {

    }
}
