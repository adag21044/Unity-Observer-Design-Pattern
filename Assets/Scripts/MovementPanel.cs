using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPanel : Subject
{
    public void ForwardOnClick()
    {
        Notify(NotificationTypes.W);
    }

    public void LeftOnClick()
    {
        Notify(NotificationTypes.A);
    }

    public void BackOnClick()
    {
        Notify(NotificationTypes.S);
    }

    public void RightOnClick()
    {
        Notify(NotificationTypes.D);
    }
}
