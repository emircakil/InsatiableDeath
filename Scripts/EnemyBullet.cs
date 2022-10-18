using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private int damage = 40;
    public double destroyBullet = 0.6;
    
  

    void Start()
    {
        
        rb.velocity = transform.right * speed;
        
    }

    void Update()
    {

       

            destroyBullet -= Time.deltaTime / 3;
        if (destroyBullet < 0)
        {
            
            Destroy(gameObject);
            destroyBullet = 0.6;

        }
        
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {



        EnemyDamage player = collision.GetComponent<EnemyDamage>();
        if (player != null) {

            player.TakeDamage(damage);
        }


        Destroy(gameObject);
        
    }
}
