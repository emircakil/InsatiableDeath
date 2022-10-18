using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 25;
    public double destroyBullet = 0.6;
    

    void Start()
    {
        rb.velocity = transform.right * speed; 
    
    }

    void Update()
    {
        
            destroyBullet -= Time.deltaTime / 4;
        if (destroyBullet < 0)
        {
           
            Destroy(gameObject);
            destroyBullet = 0.6;

        }
        
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerDamage enemy = collision.GetComponent<PlayerDamage>();

        if (enemy != null) {

            enemy.TakeDamage(damage);
        }


        Destroy(gameObject);
        
    }
}
