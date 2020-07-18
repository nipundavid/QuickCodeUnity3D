using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : ISubject
{

    private List<Observer> observers;
    private int value = 0;

    public ConcreteSubject()
    {
        observers = new List<Observer>();
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(value);
        }
    }

    public void RegisterObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o)
    {
        observers.Remove(o);
    }

    public void SetValue(int value)
    {
        this.value = value;
        NotifyObservers();
    }
}
