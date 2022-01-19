using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMneger : MonoBehaviour
{
    public static UIMneger instance;
    [SerializeField] private Image healthBar;
    private float currentHealth;
    private float maxHealth;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }
    void Update()
    {
        UpdatePlayerUI();
    }
    private void UpdatePlayerUI()
    {
        healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, currentHealth / maxHealth, 10f * Time.deltaTime);
    }
    public void UpdatePlayerHealth(float current, float max)
    {
        currentHealth = current;
        maxHealth = max;
    }
}
