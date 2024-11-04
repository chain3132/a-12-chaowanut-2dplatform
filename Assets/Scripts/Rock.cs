using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d;
    private Vector2 force;

    public void Start()
    {
        Damage = 40;
        Move();
    }
    
    public override void OnHitWith(Character character)
    {
        character.TakeDamage(Damage);
    }
    
    public override void Move()
    {
        Debug.Log("rock move with rigidbody force");
    }
}
