using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [SerializeField] private float initialMana;
    [SerializeField] private float maxMana;
    [SerializeField] private float regeneratePerSecound;
    private PlayerHealth playerHealth;
    private void Awake()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    public float mana { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        mana = initialMana;
        UpdateManaBar();
        // call RestoreMana mana once per socound because we restore mana every secound.
        InvokeRepeating(nameof(RestoreMana), 1, 1);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpendMana(10f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            RestoreManaFully();
        }
    }
    public void SpendMana(float spend)
    {
        if (mana >= spend)
        {
            mana -= spend;
            UpdateManaBar();
        }
    }
    private void RestoreMana()
    {
        //check player still live retriving player health from the same class and mana is less than maxMana.
        if (playerHealth.health > 0f && mana<maxMana)
        {
            mana += regeneratePerSecound;
            UpdateManaBar();
        }
    }
    private void RestoreManaFully()
    {
        mana = initialMana;
        UpdateManaBar();
    }
    private void UpdateManaBar()
    {
        UIMneger.Instance.UpdatePlayerMana(mana, maxMana);
    }
}
