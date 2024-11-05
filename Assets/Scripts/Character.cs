using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField]private float health;
    private float maxHealth;
    public float Health { get { return health; } set { health = value; } }
    public Animator anim;
    public Rigidbody2D rb2d;
    public Slider healthSlider;
    void Start()
    {
        UpdateHealthBar();
    }
    public void Init(int newhp)
    {
        Health = newhp;
        maxHealth = Health;
    }

    public bool IsDead()
    {
        return Health <= 0;
    }

    public  void TakeDamage(int damage)
    {
        Health -= damage;
        if (healthSlider){UpdateHealthBar();}
        if(IsDead()) { Destroy(gameObject); }
    }
    private void UpdateHealthBar()
    {
        
        healthSlider.value = Mathf.Clamp(Health / maxHealth,0,1);
    }
}
