using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public bool canCure => health < maxHealth;
    protected override void Start()
    {
        base.Start();
        UpdateHealthBar(health, maxHealth);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ToDamage(10);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestoreHealth(10);
        }
    }
    public void RestoreHealth(float cure)
    {
        if (canCure == true)
        {
            health += cure;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
            UpdateHealthBar(health, maxHealth);
        }
    }
    protected override void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        UIMneger.instance.UpdatePlayerHealth(currentHealth, maxHealth);
    }
}
