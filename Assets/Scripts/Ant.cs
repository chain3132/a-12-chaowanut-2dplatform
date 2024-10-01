using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField]private Transform[] movePoints;
    [SerializeField] private Vector2 velocity;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Init(10);
        DamageHit = 20;
        
    }
    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime );
        if(rb2d.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }
        if(rb2d.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
        }

    }
    void Flip()
    {
        velocity.x *= -1;
        Vector3 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;
    }
}
