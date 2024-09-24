using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damgeHit;
    public int DamageHit { get { return damgeHit; } set { damgeHit = value; } }

    private void Start()
    {
        Behavior();
    }

    public abstract void Behavior();
}
