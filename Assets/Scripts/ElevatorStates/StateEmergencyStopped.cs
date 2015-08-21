using UnityEngine;
using System.Collections;

public class StateEmergencyStopped : ElevatorState
{

    public override void UpdateState(Elevator gameObject)
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
