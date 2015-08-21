using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : ScriptableObject, Observer {

    private ElevatorState currentState;
    private Stack stateStack = new Stack();
    private Elevator owner;
    public Transform[] floorCoordinates;
    public int targetFloor;

    public void Init(ElevatorState state, Elevator elevator)
    {
        SetState(state);

        owner = elevator;

        floorCoordinates = new Transform[] {
            elevator.ElevatorButtons[0].transform,
            elevator.ElevatorButtons[1].transform,
            elevator.ElevatorButtons[2].transform,
        };
    }

    public void RunState() {

        currentState = GetCurrentState();

        if (currentState != null)
        {
            currentState.UpdateState(owner);

            if(currentState.IsStateDone())
            {
                PopState();
            }
        }
    }

    private ElevatorState GetCurrentState()
    {
        return stateStack.Count > 0 ? stateStack.Peek() as ElevatorState : null;
    }

    public void SetState(ElevatorState state) 
    {
        currentState = state;

        PushState(currentState);

        currentState.Enter(this);
    }

    private void PushState(ElevatorState state)
    {
        stateStack.Push(state);
    }

    public void PopState()
    {
        stateStack.Pop();

        Debug.Log("State was popped");


    }

    public void onNotify(GameObject gameObject, Event myEvent)
    {
        switch(myEvent.eventType)
        {
            case (int)Event.events.buttonClicked :
                currentState.ElevatorButtonClicked(gameObject, (ButtonClickedEvent)myEvent);
                break;
        }
    }
}