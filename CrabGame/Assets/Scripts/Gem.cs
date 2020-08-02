﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public int healingNum = 5;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var contact = collision.collider.tag;

        if(contact == "Player")
        {
			ScoreManager gemManager = FindObjectOfType<ScoreManager>();
			gemManager.AddGems(1);
            collision.gameObject.GetComponent<Player>().PlayEatSound();
            collision.gameObject.GetComponent<Player>().Heal(healingNum);
			Destroy(gameObject);
        }
    }
}
