using UnityEngine;
using System.Collections;
using System;

public class ElevatorButton : Subject {

    public int floorNumber;

    void OnMouseDown()
    {
        notify(this.gameObject, new ButtonClickedEvent(floorNumber));
    }
}
