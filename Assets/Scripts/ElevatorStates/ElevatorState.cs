using UnityEngine;
using System.Collections;

public abstract class ElevatorState : ScriptableObject {

    protected StateMachine stateMachine;

    // Has the state continue doing whatever it is doing
    public abstract void UpdateState(Elevator elevator);

    // Check if state is done with whatever it is doing
    public abstract bool IsStateDone();

    // We have reached the end of the state and would like to transition to next state in line
    public abstract void EndState();

    // Optional first function to be called after state is set 
    public virtual void Enter(StateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    public virtual void ElevatorButtonClicked(GameObject gameObject, ButtonClickedEvent myEvent) {}
}
