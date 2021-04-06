using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   public float health = 100;

    public GameObject BloodEffect;
    public GameObject DeathEffectPosition;
    public void Dies()
    {
        if (BloodEffect)
        {
            Instantiate(BloodEffect, DeathEffectPosition.transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }

    public void DealDamng(float Damage)
    {
        health -= Damage;

        if (health <= 0)
        {
            Dies();

        }
    }

}
