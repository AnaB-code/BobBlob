using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour

{
    public Slider healthSlider;
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        //healthSlider.maxValue = maxHealth;
        //healthSlider.value = currentHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        //healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Debug.Log("Player Died!");
           
    }
}
}