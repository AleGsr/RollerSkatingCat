using UnityEngine;

public interface IObserver 
{
    void Notify(Subject subject, string eventName);

}
