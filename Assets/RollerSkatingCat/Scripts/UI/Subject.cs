using UnityEngine;
using System.Collections.Generic;

public class Subject : MonoBehaviour
{
    private readonly List<IObserver> observers = new();


    public void AddObserver(IObserver observer) => observers.Add(observer);

    public void RemoveObserver(IObserver observer) => observers.Remove(observer);

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
            observer.Notify(this);
    }


}
