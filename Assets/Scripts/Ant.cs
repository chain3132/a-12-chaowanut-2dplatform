using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    private Transform[] movePoints;
    private Vector2 vector;

    public override void Behavior()
    {
        Debug.Log("ant");
    }
}
