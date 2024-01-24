using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    #region Singleton
    private static ObserverManager _instance = null;
    public static ObserverManager Instance => _instance;
    #endregion

    private List<Subject> subjects = null;

    private void Awake()
    {
        _instance = this;    
    }

    public void RegisterSubject(Subject subject)
    {
        if (subjects == null)
        {
            subjects = new List<Subject>();
        }

        subjects.Add(subject);
    }

    public void RegisterObserver(Observer observer, SubjectTypes subjectType)
    {
        if (subjects == null)
        {
            Debug.LogError("No subjects registered");
            return;
        }

        foreach (var subject in subjects)
        {
            if (subject.SubjectType == subjectType)
            {
                subject.RegisterObserver(observer);
                return;
               
            }
        }

        Debug.LogError("Subject not found");
    }
    
}
