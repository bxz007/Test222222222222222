using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameMain;
public class User : Entity {

    public static List<User> userList = new List<User>();

    private void Awake()
    {
        userList.Add(this);
    }   

    private void OnDestroy()
    {
        userList.Remove(this);
    }
}
