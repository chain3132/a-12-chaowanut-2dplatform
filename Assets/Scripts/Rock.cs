using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d;
    private Vector2 force;
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    public void Start()
    {
        
        force = new Vector2 (GetShootDirection() * 1f, 8);
        Move();
    }
    
    public override void OnHitWith(Character character)
    {
        
        if (character is Player) { character.TakeDamage(this.Damage); }
        
    }
    
    public override void Move()
    {
        rb2d.AddForce(force,ForceMode2D.Impulse);
        Debug.Log("rock move with rigidbody force");
    }
}
