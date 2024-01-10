using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 100;

    public event Action OnHealthDepleted;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;

            if (health <= 0)
            {
                OnHealthDepleted?.Invoke();
            }
        }
    } 
}
