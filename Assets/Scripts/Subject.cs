using UnityEngine;
using System.Collections.Generic;

public class Subject {

    private List<Observer> observers = new List<Observer>();

    private int numObservers;

    public void addObserver(Observer observer)
    {

    }

    public void removeObserver(Observer observer)
    {

    }

    protected void notify(const GameObject gameobject, Event myEvent)
    {
        foreach(Observer observer in observers) {
            observer.notify(gameobject, myEvent);
        }
    }
}
