using UnityEngine;
using System.Collections.Generic;

public abstract class Subject : MonoBehaviour
{
    private readonly List<IObserver> observers = new();


    public void AddObserver(IObserver observer) => observers.Add(observer);

    public void RemoveObserver(IObserver observer) => observers.Remove(observer);

    public void NotifyObservers(string eventName)
    {
        foreach (IObserver observer in observers)
            observer.Notify(this, eventName);
    }


}
