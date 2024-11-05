using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]private int damage;
    public int Damage {get {return damage; }set { damage = value; }} 
    public IShootable shooter;


    public abstract void OnHitWith(Character character);
    public abstract void Move();
    public void Init(int _damage ,IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }
    private void OnTriggerEnter2D(Collider2D other) //add later
    {
        
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject);
    }
    public int GetShootDirection()
    {
        float shootDir = shooter.SpawnPoint.position.x - shooter.SpawnPoint.parent.position.x;
        if (shootDir > 0) { return 1; }
        else return -1;
        
    }
}
