using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField]private float speed;
    private void Start()
    {
        Damage = 30;
        speed = 4;
        Move();
        
    }

    public override void OnHitWith(Character character)
    {
        character.TakeDamage(Damage);
    }

    public override void Move()
    {
        Debug.Log("Banana move with constant speed using Transform");
    }
}
