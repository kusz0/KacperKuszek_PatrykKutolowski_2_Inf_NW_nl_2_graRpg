using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
public class StatsManager : MonoBehaviour
{
    public static StatsManager Instance;
    public TMP_Text healthText;

    [Header("Combat Stats")]
    public int damage;
    public float weaponRange;
    public float knockbackForce;
    public float knockbackTime;
    public float stunTime;

    [Header("Movment Stats")]
    public int speed;

    [Header("Health Stats")]
    public int maxHealth;
    public int currentHealth;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }        
        else
        {
            Destroy(gameObject);
        }
    }

    public void UpdateMaxHealth(int amount)
    {
        maxHealth += amount;
        healthText.text = $"HP: {currentHealth} / {maxHealth}";
    }
}
