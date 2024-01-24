using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
   private List<Observer> observers = null;

   [SerializeField] private SubjectTypes subjectType;
    public SubjectTypes SubjectType => subjectType;

   public void RegisterObserver(Observer observer)
   {
       if (observers == null)
       {
           observers = new List<Observer>();
       }

       observers.Add(observer);
   }    

   public void Start()
   {
        ObserverManager.Instance.RegisterSubject(this);
   }

   public void Notify(NotificationTypes notificationType)
   {
       
       foreach (var observer in observers)
       {
           observer.OnNotify(notificationType);
       }
   }
}
