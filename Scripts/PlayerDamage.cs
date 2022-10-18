using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{

    public int health = 100;
    public GameObject deathEffect;
   


    public void TakeDamage(int damage)
    {

        health -= damage;
        
        Debug.Log("Player Health" + health);
    
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Die()
    {
        Destroy(gameObject);

        
        Instantiate(deathEffect, transform.position, transform.rotation);
        ChangeScene();
    }
}
