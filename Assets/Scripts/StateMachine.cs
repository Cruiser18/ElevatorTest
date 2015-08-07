using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : ScriptableObject, Observer {

    private ElevatorState currentState;
    private Stack stateStack = new Stack();
    private GameObject owner;

    public StateMachine(ElevatorState state, GameObject gameObject)
    {
        SetState(state);

        owner = gameObject;


    }

    public void RunState() {

        if (currentState != null)
        {
            currentState.UpdateState(owner);
        }
    }

    public void SetState(ElevatorState state) 
    {
        currentState = state;

        PushState(currentState);

        currentState.Enter();
    }

    public void PushState(ElevatorState state)
    {
        stateStack.Push(state);
    }

    public void PopState()
    {
        stateStack.Pop();
    }

    public void onNotify(GameObject gameObject, Event myEvent)
    {
        switch(myEvent.eventType)
        {
            case (int)Event.events.buttonClicked :
                currentState.ElevatorButtonClicked(gameObject, myEvent);
                break;
        }
    }
}