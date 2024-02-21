using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthSystem : MonoBehaviour
{
    public string unitName;
    public int damage;

    public int maxHP;
    public int currentHP;

    public Text Health;

    public bool TakeDamage(int hp)
    {
        Health.text = "" + currentHP;

        currentHP -= hp;

        if (currentHP <= 0)
            return true;
        else
            return false;
    }

    public void Heal(int hp)
    {
        currentHP += hp;
        if (currentHP > maxHP)
            currentHP = maxHP;
    }
    
}
