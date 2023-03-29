using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IM2073 - Low Pui Mun

public class Target : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

//End code
