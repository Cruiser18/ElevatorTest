using UnityEngine;
using System.Collections;
using System;

public class Elevator : MonoBehaviour {

    public ElevatorButton[] ElevatorButtons;
    private StateMachine stateMachine;
    public StateIdle stateIdle;
    

	// Use this for initialization
	void Start () {

        CreateStates();

        stateMachine = ScriptableObject.CreateInstance("StateMachine") as StateMachine;
        stateMachine.Init(ScriptableObject.CreateInstance("StateIdle") as StateIdle, this);

        ElevatorButtons[0].addObserver(stateMachine);
        ElevatorButtons[1].addObserver(stateMachine);
        ElevatorButtons[2].addObserver(stateMachine);
	}

    private void CreateStates()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        stateMachine.RunState();
	}


}