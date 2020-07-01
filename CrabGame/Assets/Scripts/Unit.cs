﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public int startingHP = 100;
    public int currentHP;
    public HealthBar healthBar;

    public bool isBlocking = false;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;
        if (healthBar == null)
        {
            print("Reference to Health Bar is Missing");
        }
        else
        {
            healthBar.SetMaxHealth(startingHP);
            healthBar.SetHealth(currentHP);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	protected virtual void Die()
    {
		// Que Game over screen
		Destroy(healthBar.gameObject);
    }

    public void TakeDamage(int dmg)
    {
        if (isBlocking == false)
        {
            currentHP -= dmg;
            healthBar.SetHealth(currentHP);
        }

        if (currentHP <= 0)
        {
            Die();
        }
    }
}