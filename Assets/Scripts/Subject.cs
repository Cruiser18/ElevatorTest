using UnityEngine;
using System.Collections.Generic;

public class Subject : MonoBehaviour {

    private List<Observer> observers = new List<Observer>();

    public void addObserver(Observer observer)
    {
        observers.Add(observer);
    }

    public void removeObserver(Observer observer)
    {
        observers.Remove(observer);
    }

    protected void notify(GameObject gameobject, Event myEvent)
    {
        foreach(Observer observer in observers) {
            observer.onNotify(gameobject, myEvent);
        }
    }
}
