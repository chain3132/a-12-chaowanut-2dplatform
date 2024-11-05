using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField]private float speed;
    private void Start()
    {
        speed = 2 * GetShootDirection() ;
        Move();
        
    }

    public override void OnHitWith(Character character)
    {
        if (character == null ) return;
        if(character is Enemy) { character.TakeDamage(Damage); }
        
    }
    private void Update()
    {
        Move();
    }
    public override void Move()
    {
        float newX = transform.position.x + speed *  Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;   
    }
}
