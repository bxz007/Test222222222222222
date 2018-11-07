using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameMain;
public class User : Entity {

    public static List<User> userList;

    protected internal override void OnInit(object userData)
    {
        base.OnInit(userData);
        userList.Add(this);
    }

    private void OnDestroy()
    {
        userList.Remove(this);
    }
}
