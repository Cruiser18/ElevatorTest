using UnityEngine;
using System.Collections;
using System;

public class ElevatorButton : Subject {

    public event EventHandler<ButtonClickedEventArgs> ButtonClicked;
    public int floorNumber;

    void OnMouseDown()
    {
        ButtonClickedEventArgs args = new ButtonClickedEventArgs();
        args.floorNumber = this.floorNumber;

        onButtonClicked(args);
    }

    private void onButtonClicked(ButtonClickedEventArgs e) 
    {
        EventHandler<ButtonClickedEventArgs> handler = ButtonClicked;
        if (handler != null)
        {
            handler(this, e);
        }
    }
}
