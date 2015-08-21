using UnityEngine;
using System.Collections;

public class StateMoving : ElevatorState
{
    private bool isDone = false;

    private float movementSpeed = 2.0f;

    public override void UpdateState(Elevator elevator)
    {


        Transform elevatorPosition = elevator.gameObject.transform;
        Transform floorPosition = stateMachine.floorCoordinates[stateMachine.targetFloor].transform;

        float step = movementSpeed * Time.deltaTime;
        elevatorPosition.position = Vector2.MoveTowards(
            elevatorPosition.position,
            new Vector2(elevatorPosition.position.x, floorPosition.position.y),
            step);

        if (Vector2.Distance(new Vector2(0, elevatorPosition.position.y), new Vector2(0, floorPosition.position.y)) < 0.01)
        {
            StateOpeningDoors state;

            state = ScriptableObject.CreateInstance("StateOpeningDoors") as StateOpeningDoors;

            stateMachine.SetState(state);

            isDone = true;
        }
    }

    // Check if state is done with whatever it is doing
    public override bool IsStateDone()
    {
        return isDone;
    }

    // We have reached the end of the state and would like to transition to next state in line
    public override void EndState()
    {

    }
	
}