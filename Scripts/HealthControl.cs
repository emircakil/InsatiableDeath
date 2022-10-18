

using UnityEngine;

public class HealthControl : MonoBehaviour
{
    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject health4;
  //  public GameObject player;
    private int playerHealth;
    PlayerDamage playerDamage;
    
    

    void Start()
    {
        playerDamage = GetComponent<PlayerDamage>();
        health1.gameObject.SetActive(true);
        health2.gameObject.SetActive(true);
        health3.gameObject.SetActive(true);
        health4.gameObject.SetActive(true);

        

    }

    // Update is called once per frame
    void Update()
    {
        playerHealth = playerDamage.health;
         if (playerHealth <=0) {

            health1.gameObject.SetActive(false);
            health2.gameObject.SetActive(false);
            health3.gameObject.SetActive(false);
            health4.gameObject.SetActive(false);
            playerDamage.Die();

            // gameOver.gameObject.SetActive(true);
        }else if (playerHealth <= 25)
        {

            health1.gameObject.SetActive(true);
            health2.gameObject.SetActive(false);
            health3.gameObject.SetActive(false); 
            health4.gameObject.SetActive(false); 
        }else  if (playerHealth <= 50)
        {

            health1.gameObject.SetActive(true);
            health2.gameObject.SetActive(true);
            health3.gameObject.SetActive(false);
            health4.gameObject.SetActive(false);

        }
         
        else if (playerHealth <= 75)
        {

            health1.gameObject.SetActive(true);
            health2.gameObject.SetActive(true);
            health3.gameObject.SetActive(true);
            health4.gameObject.SetActive(false);
        }
       
          
       
    }
}
