using UnityEngine;
using System.Collections;

public class StateIdle : ElevatorState {

    public bool elevatorDoorsOpen = false;

    public override void UpdateState(Elevator gameObject)
    {
        
    }

    // Check if state is done with whatever it is doing
    public override bool IsStateDone()
    {
        return false;
    }

    // We have reached the end of the state and would like to transition to next state in line
    public override void EndState()
    {

    }

    public override void ElevatorButtonClicked(GameObject gameObject, ButtonClickedEvent myEvent)
    {
        Debug.Log("Elevator button was clicked for floor: " + myEvent.floorNumber);

        stateMachine.SetState(ScriptableObject.CreateInstance("StateMoving") as StateMoving);

        stateMachine.targetFloor = myEvent.floorNumber;
    }

}