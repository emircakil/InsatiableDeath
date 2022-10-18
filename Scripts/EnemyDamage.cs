using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public int health = 100;

    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {

        health -= damage;

        Debug.Log("Enemy Health" + health);

        if (health <= 0) {


            Die();
        }
    
    }

    void Die() {
        Destroy(this.gameObject);
        Instantiate(deathEffect, transform.position, transform.rotation);
        
    }


}
