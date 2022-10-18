using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;
    public Animator animator;
    [SerializeField] private float shootDelay = 5f;
    public AudioSource silah;



    public double shootTime = 1;

    void Start()
    {
        silah = GetComponent<AudioSource>();   
    }
    void Update()
    {
       
            if ((Input.GetKeyDown(KeyCode.Space)))
            {

                if (animator.GetBool("Shoot")) return;
                animator.SetBool("Shoot", true);

                Shoot();

            silah.Play();

            }

        



        }

    void ResetShoot()
    {
        animator.SetBool("Shoot", false);
     
    }

    void  Shoot() {
      //  animator.Play("Idle");

        Invoke("ResetShoot", shootDelay);

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }

}
