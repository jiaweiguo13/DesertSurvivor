using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMneger : Singleton<UIMneger>
{
    
    [SerializeField] private Image healthBar;
    [SerializeField] private Image manaBar;
    [SerializeField] private GameObject inventaryPanel;
    private float currentHealth;
    private float maxHealth;
    private float currentMana;
    private float maxMana;
  
    void Update()
    {
        UpdatePlayerUI();
    }
    private void UpdatePlayerUI()
    {
        // set  bar by using linear interpolation
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, currentHealth / maxHealth, 10f * Time.deltaTime);
        manaBar.fillAmount = Mathf.Lerp(manaBar.fillAmount, currentMana / maxMana, 10f * Time.deltaTime);
    }
    public void UpdatePlayerHealth(float current, float max)
    {
        currentHealth = current;
        maxHealth = max;
    }

    public void UpdatePlayerMana(float current, float max)
    {
        currentMana = current;
        maxMana = max;
    }

    public void OpenClossInventary()
    {
        inventaryPanel.SetActive(!inventaryPanel.activeSelf);
    }
    
}
