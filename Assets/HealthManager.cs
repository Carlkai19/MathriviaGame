using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount =  100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TESTING ONLY
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Heal(5);
        }
        //TESTING ONLY

    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;

    }

    public void Heal(float HealingAmount)
    {
        healthAmount += HealingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
