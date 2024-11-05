using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crocodile : Enemy,IShootable
{
    float attackRange;
    public float AttackRange { get { return attackRange; } set { attackRange = value; } }
    private Animator animator;
    public Player player;
    

    public float ReloadTime { get; set; }   
    public float WaitTime { get; set; }

    [field: SerializeField] public Transform SpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    


    void Start()
    {
        Init(30);
        WaitTime = 0.0f;
        ReloadTime = 5.0f;
        DamageHit = 30;
        AttackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
        animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
        Behavior();
    }
    public override void Behavior()
    {
        Vector2 distance = player.transform.position - transform.position;
        if (distance.magnitude <= attackRange)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            animator.SetTrigger("Shoot");
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Rock rockObj = obj.GetComponent<Rock>();
            rockObj.Init(40,this);
            WaitTime = 0;
        }
    }
}