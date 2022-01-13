using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float initialHealth;
    [SerializeField] float maxHealth;
    public float health { get; set; }
    public void ToDamage(float damage)
    {
        if (damage > 0f)
        {
            health -= damage;
            UpdateHealthBar(health, maxHealth);
            if (health <= 0)
            {
                UpdateHealthBar(health, maxHealth);
                Dieth();
            }
        }
        else
        {
            return;
        }
    }
    public void UpdateHealthBar(float current , float max)
    {

    }
    protected void Dieth()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
