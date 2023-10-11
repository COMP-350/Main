using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action playerDeath;
    public float health, maxHealth;
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void playerHit()
    {
        health -= maxHealth;
        if(health <= 0) {
            health = 0;
            Debug.Log("You died lol");
            playerDeath?.Invoke();
        }
    }
}
