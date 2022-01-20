using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMneger : Singleton<UIMneger>
{
    
    [SerializeField] private Image healthBar;
    private float currentHealth;
    private float maxHealth;
  
    void Update()
    {
        UpdatePlayerUI();
    }
    private void UpdatePlayerUI()
    {
        // set health bar by using linear interpolation
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, currentHealth / maxHealth, 10f * Time.deltaTime);
    }
    public void UpdatePlayerHealth(float current, float max)
    {
        currentHealth = current;
        maxHealth = max;
    }
}
