using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public double shootTime = 1;
    public GameObject player;

    private void Awake()
    {

        

    }
    void Update()
    {

        if (player != null)
        {

            if (player.transform.position.x + 30 >= this.transform.position.x)
            {




                shootTime -= Time.deltaTime;
                if (shootTime < 0)
                {

                    Shoot();
                    shootTime = 1;
                }

            }
        }
        
    }
    void Shoot() { 
    
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }

}
