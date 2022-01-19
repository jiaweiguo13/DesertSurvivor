using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float initialHealth;
    [SerializeField] protected float maxHealth;
    public float health { get; set; }
    // Start is called before the first frame update
    protected virtual void Start()
    {
        health = initialHealth;
        
    }
    public void ToDamage(float damage)
    {
        if (damage <= 0f)
        {
            return;
        }
        else
        {
            if (health > 0f)
            {
                health -= damage;
                UpdateHealthBar(health, maxHealth);
                if (health <= 0f)
                {
                    Dieth();
                }
            }
        }
    }
    protected virtual void UpdateHealthBar(float currentHealth , float maxHealth)
    {

    }
    protected virtual void Dieth()
    {

    }
    
}
