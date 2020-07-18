using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver : Observer
{
    private ISubject concreteSubject;
  
    public void Update(int value)
    {
        Debug.Log(value);
    }

    public ConcreteObserver(ISubject subject)
    {
        this.concreteSubject = subject;
        concreteSubject.RegisterObserver(this);
    }
}
