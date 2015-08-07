using UnityEngine;
using System.Collections;
using System;

public class Elevator : MonoBehaviour {

    public ElevatorButton[] ElevatorButtons;
    private ElevatorState[] states = new ElevatorState[Enum.GetNames(typeof(Enums.ElevatorStates)).Length];
    private StateMachine stateMachine;
    public StateIdle stateIdle;
    

	// Use this for initialization
	void Start () {

        CreateStates();

        stateMachine = new StateMachine(new StateIdle(), this.gameObject);

        ElevatorButtons[0].addObserver(stateMachine);
        ElevatorButtons[1].addObserver(stateMachine);

        // Subscribe to each elevator button
        foreach (ElevatorButton button in ElevatorButtons)
        {
            button.ButtonClicked += FloorButtonClicked;
        }
	}

    private void CreateStates()
    {
        
    }

    private void FloorButtonClicked(object sender, ButtonClickedEventArgs e)
    {
        Debug.Log(e.floorNumber);
    }
	
	// Update is called once per frame
	void Update () {
        stateMachine.RunState();
	}


}