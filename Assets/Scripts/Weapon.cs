using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]private int damage;
    public int Damage {get {return damage; }set { damage = value; }} 
    protected string owner;

    private void Start()
    {
        
    }

    public abstract void OnHitWith(Character character);
    public abstract void Move();
    private void OnTriggerEnter2D(Collider2D other) //add later
    {
        if (other.tag == "Player")
        {
            OnHitWith(other.GetComponent<Character>());
        }
        
        Destroy(this.gameObject);
    }
    public int GetShootDirection()
    {
        return 1;
    }
}
