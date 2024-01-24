using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : Observer
{
    private void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectTypes.MovementPanel);
    }

    public override void OnNotify(NotificationTypes notificationType)
    {
        switch (notificationType)
        {
            case NotificationTypes.W:
                transform.Translate(Vector3.forward);
                break;
            case NotificationTypes.A:
                transform.Translate(Vector3.left);
                break;
            case NotificationTypes.S:
                transform.Translate(Vector3.back);
                break;
            case NotificationTypes.D:    
                transform.Translate(Vector3.right);
                break;    
            default:
                break;
        }
    }
}
