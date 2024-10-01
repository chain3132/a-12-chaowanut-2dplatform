using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]private int health;
    public int Health { get { return health; } set { health = value; } }
    public Animator anim;
    public Rigidbody2D rb2d;

    public void Init(int newhp)
    {
        Health = newhp;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }
    public  void TakeDamage(int damage)
    {
        Health -= damage;
        IsDead();
    }
}
