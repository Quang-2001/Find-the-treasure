using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth;

    public int currentHealth;

    public float CurrentHealthPercentage
    { 
        get 
        {
            return (float)currentHealth / (float)maxHealth; 
        }
    }

    private Character _cc;

    private void Awake()
    {
        currentHealth = maxHealth;
        _cc = GetComponent<Character>();
    }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log(gameObject.name + "took damage" + damage);
        Debug.Log(gameObject.name + "current health" + currentHealth);
        CheckHealth();
    }

    private void CheckHealth()
    {
        if(currentHealth <= 0)
        {
            _cc.SwitchStateTo(Character.CharacterState.Dead);
        }
    }

    public void AddHealth(int health)
    {
        currentHealth += health;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
